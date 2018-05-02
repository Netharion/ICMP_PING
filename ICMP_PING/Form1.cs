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
using GMap.NET.WindowsForms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using System.Reflection;




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
            
            int numOfDomains = Convert.ToInt32(numOfDomainsTxtBox.Text);
            var domains = DomainLists.moztop();
            batchProgressBar.Minimum = 0;
            batchProgressBar.Maximum = numOfDomains;
            batchProgressBar.Value = 0;

            for (int c = 0; c <= numOfDomains-1; c++)
            {
                ListViewItem list = new ListViewItem();
                pingAsyncResponse aSYNCping = new pingAsyncResponse();
                string currentDomain = domains[c];
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
        private void MapTraceroute(string domain)
        {
            GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");
            GMapOverlay routes = new GMapOverlay("routes");
            List<PointLatLng> points = new List<PointLatLng>();
            var trace = tracert.GetTraceRoute(tracert_Textbox.Text);
            foreach (var element in trace)
            {
                double lattitude;
                double longitude;

                var ipdetails = tracert.IPGEOINFO(element);
                if (ipdetails[0] == null)
                {
                    continue;
                }
                else
                {
                    lattitude = Convert.ToDouble(ipdetails[0].ToString());
                    longitude = Convert.ToDouble(ipdetails[1].ToString());

                    string coordinates = (ipdetails[0].ToString()) + (",") + (ipdetails[1].ToString());


                    GMap.NET.WindowsForms.GMapMarker marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(lattitude, longitude), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                    marker.Dispose();
                    marker.ToolTipText = ("Loc: " + coordinates + "\n" + ipdetails[2] + "\n" + ipdetails[3] + "\n" + ipdetails[4]);
                    marker.ToolTip.Fill = Brushes.Black;
                    marker.ToolTip.Foreground = Brushes.White;
                    marker.ToolTip.Stroke = Pens.Black;
                    marker.ToolTip.TextPadding = new Size(20, 20);

                    points.Add(new PointLatLng(lattitude, longitude));
                    Console.WriteLine(ipdetails[2]);

                    markers.Markers.Add(marker);
                    gmapcontrol.Overlays.Clear();
                    gmapcontrol.Overlays.Add(markers);
                }

            }
            try
            {
                GMapRoute route = new GMapRoute(points, "test");
                routes.Routes.Add(route);
                gmapcontrol.Overlays.Add(routes);
            }
            catch
            {

            }

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

 

        private void Form1_Load(object sender, EventArgs e)
        {
            gmapcontrol.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmapcontrol.ShowCenter = false;
            gmapcontrol.SetPositionByKeywords("Gulf of Mexico");
        }



        private void traceroute_button_Click(object sender, EventArgs e)
        {
            var thread = new Thread(
                () => MapTraceroute(tracert_Textbox.Text));

            thread.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            char badchar = ('\x005c');
            Console.WriteLine(badchar);
            //DomainLists.moztop500();
        }
    }
}
