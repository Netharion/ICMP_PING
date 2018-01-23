using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net.NetworkInformation;



namespace ICMP_PING
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        CancellationTokenSource cts;
        
        

        private async void connectButton_Click(object sender, EventArgs e)
        {

            ListViewItem list = new ListViewItem();
            pingAsyncResponse aSYNCping = new pingAsyncResponse();
            string currentDomain = domainTextBox.Text;
            string[] result = await aSYNCping.info(currentDomain);

            list.Text = currentDomain;
            for (int count = 1; count <= 5; count++)
            {
                list.SubItems.Add(result[count]);
            }
            dataViewList.Items.Add(list);
            
        }

        private async void batchButton_Click(object sender, EventArgs e)
        {
            List<string> domainList = new List<string>();
            StreamReader domainTXT = new StreamReader("domains.txt");
            int numOfDomains = Convert.ToInt32(numOfDomainsTxtBox.Text);
            batchProgressBar.Minimum = 0;
            batchProgressBar.Maximum = numOfDomains;
            batchProgressBar.Value = 0;

            for (int c = 1; c <= numOfDomains; c++)
            {
                ListViewItem list = new ListViewItem();
                pingAsyncResponse aSYNCping = new pingAsyncResponse();
                string currentDomain = domainTXT.ReadLine();                
                string[] result = await aSYNCping.info(currentDomain);
                cts = new CancellationTokenSource();

                list.Text = currentDomain;
                for (int count = 1; count <= 5; count++)
                {
                    list.SubItems.Add(result[count]);
                }
                dataViewList.Items.Add(list);
                try
                {
                    batchProgressBar.Value = batchProgressBar.Value + 1;
                }
                catch
                {
                    batchProgressBar.Value = batchProgressBar.Maximum;
                }
                
            }
            batchProgressBar.Value = numOfDomains;
            
        }

        private void canceAsyncPingButton_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
            }
        }
    }
}
