using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Threading;
using HtmlAgilityPack;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String http = Convert.ToString(this.listView1.SelectedItems[0].Tag);

            Thread thread = new Thread(() =>
            {
                using (WebClient wc = new WebClient())
                {
                    ICredentials credentials = new NetworkCredential("pleaf", "sting0413", "tti");
                    IWebProxy webProxy = new WebProxy("http://proxyanon.ttiinc.com:8080");
                    webProxy.Credentials = credentials;
                    wc.Proxy = webProxy;                    

                    wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

                    Uri httpUri = new Uri(http);

                    String fileName = System.IO.Path.GetFileName(httpUri.LocalPath);

                    wc.DownloadFileAsync(new Uri(http), "C:\\dev\\" + fileName);

                }
            });
            thread.Start();


            //using (Ionic.Zip.ZipFile z = Ionic.Zip.ZipFile.Read("c:\\dev\\redo.zip"))
            //{
            //    foreach (Ionic.Zip.ZipEntry entry in z)
            //    {
            //        //entry.Extract("redo",Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
            //        entry.Extract("c:\\dev", Ionic.Zip.ExtractExistingFileAction.OverwriteSilently);
            //    }
            //}
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;                
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                MessageBox.Show("Complete");
            });
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.textBox1.Text = e.Item.Tag.ToString() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();

        }
    }
}
