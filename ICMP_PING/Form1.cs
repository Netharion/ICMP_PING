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
using System.Net;



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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var LanScanner = new LanScanner();
            Console.WriteLine(LanScanner.DetermineCompName("192.168.0.8"));
            Console.WriteLine(LanScanner.GetMACAddressFromARP("192.168.0.8"));

            
        }

        private async void lanStartScan_Click(object sender, EventArgs e)
        {
            string fromIP = (FROMiptextbox1.Text + "." + FROMiptextbox2.Text + "." + FROMiptextbox3.Text + ".");
            string toIP = (TOiptextbox1.Text + "." + TOiptextbox2.Text + "." + TOiptextbox3.Text + "." + TOiptextbox4.Text);
            
            int startIP = Convert.ToInt32(FROMiptextbox4.Text);
            int finishIP = Convert.ToInt32(TOiptextbox4.Text);

            while (startIP < finishIP)
            {                
                ListViewItem list = new ListViewItem();
                var LanScanner = new LanScanner();
                string currentDomain = (fromIP + (startIP.ToString()));

                Console.WriteLine(currentDomain);
                string[] result = await LanScanner.info(currentDomain);                

                var testResult = result[0];

                if (testResult != "")
                {
                    

                    list.Text = currentDomain;
                    for (int count = 1; count <= 3; count++)
                    {
                        list.SubItems.Add(result[count]);
                    }
                    lanDataViewList.Items.Add(list);
                    lanDataViewList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                    lanDataViewList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    startIP++;

                }
                else
                {
                    startIP++;
                    
                    
                }
                



            }


            

        }
    }
}
