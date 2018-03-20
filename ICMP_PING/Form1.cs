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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

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

        private async void lanStartScan_Click(object sender, EventArgs e)
        {
            lanDataViewList.Items.Clear();
            string fromIP = (FROMiptextbox1.Text + "." + FROMiptextbox2.Text + "." + FROMiptextbox3.Text + ".");
            string toIP = (TOiptextbox1.Text + "." + TOiptextbox2.Text + "." + TOiptextbox3.Text + "." + TOiptextbox4.Text);

            int startIP = Convert.ToInt32(FROMiptextbox4.Text);
            int finishIP = Convert.ToInt32(TOiptextbox4.Text);

            batchProgressBar.Minimum = startIP;
            batchProgressBar.Maximum = finishIP;
            batchProgressBar.Value = startIP;





            for (int IPcount = (startIP); IPcount <= (finishIP); IPcount++)
            {
                ListViewItem list = new ListViewItem();
                var LanScanner = new LanScanner();
                string currentDomain = (fromIP + (IPcount.ToString()));

                try
                {
                    batchProgressBar.Value = batchProgressBar.Value + 1;
                }
                catch
                {
                    batchProgressBar.Value = batchProgressBar.Maximum;
                }


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


                }
                else
                {
                    continue;
                }
            }
        }

        private async void LanScan(string domain)
        {
            ListViewItem list = new ListViewItem();
            var LanScanner = new LanScanner();

            string[] result = await LanScanner.info(domain);
            var testResult = result[0];            

            if (testResult != "")
            {
                list.Text = domain;
                for (int count = 1; count <= 3; count++)
                {
                    list.SubItems.Add(result[count]);
                }                
                ThreadHelper.SetList(this, lanDataViewList, list);
            }
            ThreadHelper.UpdateProgressBar(this, batchProgressBar, batchProgressBar.Value + 1);



        }

        private void ThreadTest()
        {
            var thread1 = new Thread(
                () => LanScan("192.168.0.1"));
            var thread2 = new Thread(
                () => LanScan("192.168.0.5"));
            var thread3 = new Thread(
                () => LanScan("192.168.0.8"));
            var thread4 = new Thread(
                () => LanScan("192.168.0.24"));
            var thread5 = new Thread(
                () => LanScan("192.168.0.110"));



            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();

        }
        private void ThreadTestTwo()
        {
            ThreadHelper.SetListClear(this, lanDataViewList);
            string fromIP = (FROMiptextbox1.Text + "." + FROMiptextbox2.Text + "." + FROMiptextbox3.Text + ".");
            string toIP = (TOiptextbox1.Text + "." + TOiptextbox2.Text + "." + TOiptextbox3.Text + "." + TOiptextbox4.Text);

            int startIP = Convert.ToInt32(FROMiptextbox4.Text);
            int finishIP = Convert.ToInt32(TOiptextbox4.Text);

            batchProgressBar.Minimum = startIP;
            batchProgressBar.Maximum = finishIP;
            batchProgressBar.Value = startIP;

            for (int IPcount = (startIP); IPcount <= (finishIP); IPcount++)
            {
                string currentDomain = (fromIP + (IPcount.ToString()));                
                ThreadPool.QueueUserWorkItem(
                    o => LanScan(currentDomain)
                    );
                
            }
            batchProgressBar.Value = batchProgressBar.Maximum;

            

        }

        private void scan_button_Click(object sender, EventArgs e)
        {
            ThreadTestTwo();
        }
    }
}
