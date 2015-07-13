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

namespace WindowsFormsApplication1
{
    public partial class frmMain : DevComponents.DotNetBar.OfficeForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private String fullPath;

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
            
            ListViewGroup gLatest = new ListViewGroup("Latest");
            ListViewGroup gArchive = new ListViewGroup("Archive");
            int iCount = 0;

            this.listView1.Groups.Add(gLatest);
            this.listView1.Groups.Add(gArchive);

            ListViewItem item = null;
            //Boolean isHeader = false;
            foreach (HtmlAgilityPack.HtmlNode link in rootDocument.DocumentNode.SelectNodes("//div[@class='text']"))
            {
                // Console.Write(link.InnerHtml);
                foreach (HtmlAgilityPack.HtmlNode p in link.ChildNodes)
                {

                    if (!p.FirstChild.Name.Equals("strong"))
                    {
                        String display = p.ChildNodes[0].InnerHtml;
                        display = display.Replace(".zip", "");

                        String url = p.ChildNodes[0].Attributes[0].Value;
                        item = new ListViewItem(display);
                        item.SubItems.Add(url);
                        //if (iCount == 0)
                        //{
                        //    item.Group = gLatest;
                        //}
                        //else
                        //{
                        //    item.Group = gArchive;
                        //}

                        //item.Tag = match.Value;

                        this.listView1.Items.Add(item);
                        iCount++;
                    }
                    else
                    {
                        item.Tag += p.InnerHtml;
                    }


                }

                
            }
        }

        private void listView1_ItemSelectionChanged_1(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
            String test = Convert.ToString(e.Item.Tag).Replace("<br>","<br/>");
            
            this.labelX1.Text = test;
            
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

            if (this.listView1.SelectedItems.Count == 0)
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

            ListViewItem item = this.listView1.SelectedItems[0];
            String http = item.SubItems[1].Text;            
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
                            credentials= new NetworkCredential(Properties.Settings.Default.proxyUser, Properties.Settings.Default.proxyPwd);
                        }
                        else
                        {
                            credentials = new NetworkCredential(Properties.Settings.Default.proxyUser, Properties.Settings.Default.proxyPwd, "tti");
                        }

                        IWebProxy webProxy = new WebProxy(String.Format("{0}:{1}",Properties.Settings.Default.proxyUrl, Properties.Settings.Default.proxyPort));
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

                    //z.ExtractProgress += new EventHandler<Ionic.Zip.ExtractProgressEventArgs>(this.client_Extract);

                    double itemCount = 0.0;
                    double totalCount = z.Entries.Count;
                    double percentage = itemCount / totalCount * 100;

                    foreach (Ionic.Zip.ZipEntry entry in z)
                    {
                        itemCount++;                        
                        if (!entry.FileName.Contains("openxcom/UFO") && !entry.FileName.Contains("openxcom/TFTD"))
                        {
                            entry.Extract("c:\\program files", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);                            
                        }

                        Console.WriteLine(int.Parse(Math.Truncate(percentage).ToString()));

                        //this.progressBarX1.Value = int.Parse(Math.Truncate(percentage).ToString());
             
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