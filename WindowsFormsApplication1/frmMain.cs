using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.Threading;
using System.Net;
using System.IO;
using DevComponents.AdvTree;

namespace WindowsFormsApplication1
{
    public partial class frmMain : DevComponents.DotNetBar.OfficeForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private String fullPath;

        private Node createChildNode(String nodeText, String subText, Image image, ElementStyle subItemStyle) 
        {
            Node childNode = new Node(nodeText);
            childNode.Image = image;
            childNode.Cells.Add(new Cell(subText,subItemStyle));
            return childNode;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            HtmlAgilityPack.HtmlWeb website = new HtmlAgilityPack.HtmlWeb();
            HtmlAgilityPack.HtmlDocument rootDocument = null;            

            if (Properties.Settings.Default.requiresProxy)
            {
                rootDocument = website.Load("http://openxcom.org/git-builds/", Properties.Settings.Default.proxyUrl, Properties.Settings.Default.proxyPort, Properties.Settings.Default.proxyUser, Properties.Settings.Default.proxyPwd);
            }
            else
            {
                rootDocument = website.Load("http://openxcom.org/git-builds/");                
            }            
            
            int iCount = 0;

            ElementStyle groupStyle = new ElementStyle();
            groupStyle.TextColor = Color.Navy;
            groupStyle.Font =  new Font(this.advTree1.Font.FontFamily, 9.5F);
            groupStyle.Name = "groupstyle";
            advTree1.Styles.Add(groupStyle);

            // Define sub-item style, simply to make text gray
            ElementStyle subItemStyle = new ElementStyle();
            subItemStyle.TextColor = Color.Gray;
            subItemStyle.Name = "subitemstyle";
            advTree1.Styles.Add(subItemStyle);

            Node gnLatest = new Node("Latest", groupStyle);
            gnLatest.Expanded = true;
            advTree1.Nodes.Add(gnLatest);

            Node gnArchive = new Node("Archive", groupStyle);
            gnArchive.Expanded = false;
            advTree1.Nodes.Add(gnArchive);

            //Boolean isHeader = false;
            Node item = null;
            List<String> items = null;
            foreach (HtmlAgilityPack.HtmlNode link in rootDocument.DocumentNode.SelectNodes("//div[@class='text']"))
            {
                
                // Console.Write(link.InnerHtml);
                foreach (HtmlAgilityPack.HtmlNode p in link.ChildNodes)
                {
                    
                    if (!p.FirstChild.Name.Equals("strong"))
                    {
                        String display = p.ChildNodes[0].InnerHtml.Replace("openxcom_git_master_","");
                        String subText = p.ChildNodes[1].InnerHtml.Replace("- ","");
                        display = display.Replace(".zip", "");

                        String url = p.ChildNodes[0].Attributes[0].Value;
                        items = new List<String>();
                        items.Add(url);

                        item = createChildNode(display, subText, (Image)Properties.Resources.ResourceManager.GetObject("openxcom24"), subItemStyle);
                       
                        if (iCount == 0)
                        {
                            gnLatest.Nodes.Add(item);
                        }
                        else
                        {
                            gnArchive.Nodes.Add(item);
                        }

                        iCount++;
                        item.Tag = items;
                    }
                    else
                    {
                        items.Add(p.InnerHtml);
                        
                    }
                }

                

                
            }
        }

        private void advTree1_CellSelected(object sender, AdvTreeCellEventArgs e)
        {
            List<String> items = (List<String>)e.Cell.Tag;

            if (items == null) return;
     
            this.labelX1.Text = Convert.ToString(items[1].ToString()).Replace("<br>", "<br/>");
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            if (this.advTree1.SelectedNodes.Count == 0)
            {
                MessageBox.Show("A nightly version was not selected...process cancelled.");
                return;
            }

            if (!Directory.Exists("c:\\program files\\openxcom"))
            {
                MessageBox.Show("Game not found...process cancelled.");
                return;
            }

            this.progressBarX1.Visible = true;

            Node item = this.advTree1.SelectedNode;
            List<String> items = (List<String>)item.Tag;
            String http = items[0].ToString();
            String fileName = System.IO.Path.GetFileName(new Uri(http).LocalPath);

            String folderPath;

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    folderPath = fbd.SelectedPath;
                }
                else
                {
                    return;
                }
            }

            fullPath = String.Format("{0}\\{1}", folderPath, fileName);

            this.progressBarX1.Text = "Initializing...";

            Thread thread = new Thread(() =>
            {
                using (WebClient wc = new WebClient())
                {

                    if (Properties.Settings.Default.requiresProxy)
                    {
                        ICredentials credentials;
                        if (Properties.Settings.Default.proxyDomain.Equals(""))
                        {
                            credentials = new NetworkCredential(Properties.Settings.Default.proxyUser, Properties.Settings.Default.proxyPwd);
                        }
                        else
                        {
                            credentials = new NetworkCredential(Properties.Settings.Default.proxyUser, Properties.Settings.Default.proxyPwd, "tti");
                        }

                        IWebProxy webProxy = new WebProxy(String.Format("{0}:{1}", Properties.Settings.Default.proxyUrl, Properties.Settings.Default.proxyPort));
                        webProxy.Credentials = credentials;
                        wc.Proxy = webProxy;
                    }

                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

                    wc.DownloadFileAsync(new Uri(http), fullPath);

                }
            });
            thread.Start();                        
                
                          
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                this.progressBarX1.Text = "Downloading...";
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                progressBarX1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {                
                this.progressBarX1.Value = 0;
                this.progressBarX1.Text = "Installing...";
                this.progressBarX1.Refresh();

                if (this.chkPerformBackup.Checked)
                {
                    using (Ionic.Zip.ZipFile z = new Ionic.Zip.ZipFile())
                    {
                        z.AddDirectory("c:\\program files\\openxcom");
                        z.Save(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\openxcom_backup.zip");
                    }
                }                

                using (Ionic.Zip.ZipFile z = Ionic.Zip.ZipFile.Read(fullPath))
                {

                    foreach (Ionic.Zip.ZipEntry entry in z)
                    {                      
                        if (!entry.FileName.Contains("openxcom/UFO") && !entry.FileName.Contains("openxcom/TFTD"))
                        {
                            entry.Extract("c:\\program files", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);                            
                        }
                    }
                }

                MessageBox.Show("Installation Complete");

                this.progressBarX1.Visible = false;
            });
        }

        void client_Extract(object sender, Ionic.Zip.ExtractProgressEventArgs e)
        {
            
        }
        
        private void sideNavItem3_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.requiresProxy == true)
            {
                this.checkBoxX2.Checked = true;
            }

            this.txtProxyUrl.Text = Properties.Settings.Default.proxyUrl;
            this.txtProxyPort.Text = Convert.ToString(Properties.Settings.Default.proxyPort);
            this.txtProxyUserId.Text = Properties.Settings.Default.proxyUser;
            this.txtProxyPassword.Text = Properties.Settings.Default.proxyPwd;
        }

        private void checkBoxX2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.lblUrl.Enabled = checkBoxX2.Checked;
            this.txtProxyUrl.Enabled = checkBoxX2.Checked;            
            this.lblPort.Enabled = checkBoxX2.Checked;
            this.txtProxyPort.Enabled = checkBoxX2.Checked;
            this.lblPassword.Enabled = checkBoxX2.Checked;
            this.txtProxyPassword.Enabled = checkBoxX2.Checked;
            this.lblUser.Enabled = checkBoxX2.Checked;
            this.txtProxyUserId.Enabled = checkBoxX2.Checked;
            this.lblDomain.Enabled = checkBoxX2.Checked;
            this.txtDomain.Enabled = checkBoxX2.Checked;
                        
            Properties.Settings.Default.requiresProxy = checkBoxX2.Checked;
            Properties.Settings.Default.Save();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.proxyUrl = this.txtProxyUrl.Text.Replace("http://","").Replace("https://","");
            Properties.Settings.Default.proxyPort = Convert.ToInt32(this.txtProxyPort.Text);
            Properties.Settings.Default.proxyDomain = this.txtDomain.Text;
            Properties.Settings.Default.proxyUser = this.txtProxyUserId.Text;
            Properties.Settings.Default.proxyPwd = this.txtProxyPassword.Text;

            Properties.Settings.Default.Save();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            this.txtProxyPassword.UseSystemPasswordChar = !this.txtProxyPassword.UseSystemPasswordChar;
        }

        
        
    }
}