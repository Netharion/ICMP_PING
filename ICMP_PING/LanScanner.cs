using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Net;
using System.Diagnostics;
using System.Runtime.InteropServices;


namespace ICMP_PING
{
    public class LanScanner
    {
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        static extern int SendARP(int DestIP, int SrcIP, byte[] pMacAddr, ref uint PhyAddrLen);



        public async Task<string> AsyncDetermineCompName(string IP)
        {
            //to return to default must be public async Task<string>
            //Task<string> determineCompName = new Task<string>(async() =>
            //{
            //    try
            //    {                    
            //        IPAddress myIP = IPAddress.Parse(IP);
            //        IPHostEntry GetIPHost = await Dns.GetHostEntryAsync(myIP);
            //        List<string> compName = GetIPHost.HostName.ToString().Split('.').ToList();
            //        Console.WriteLine("this task is running");                    
            //        return compName.First();
            //    }
            //    catch
            //    {
            //        return "";
            //    }

            //});

            try
            {
                IPAddress myIP = IPAddress.Parse(IP);
                IPHostEntry GetIPHost = await Dns.GetHostEntryAsync(myIP);
                List<string> compName = GetIPHost.HostName.ToString().Split('.').ToList();
                Console.WriteLine("Checking comp name of" + myIP);
                return compName.First();
            }
            catch
            {
                Console.WriteLine(IP = "failed comp checking");
                return "";
            }
            //determineCompName.Start();
            //var result = determineCompName.Result;
            //return result;
            
        }

        public static string DetermineCompName(string IP)
        {
            // determine host name of provided IP
            try
            {
                IPAddress myIP = IPAddress.Parse(IP);
                IPHostEntry GetIPHost = Dns.GetHostEntry(myIP);
                List<string> compName = GetIPHost.HostName.ToString().Split('.').ToList();
                return compName.First();
            }
            catch
            {
                return "";
            }
            
        }

        public async Task<string> asyncGetMacAddressFromARP(string hostNameOrAddress)
        {
          //bool result = await isHostAccessibleAsync(hostNameOrAddress);
            
         // if (!isHostAccessibleAsync(hostNameOrAddress)) return null;

            

            byte[] macAddr = new byte[6];


            IPAddress IP = IPAddress.Parse(hostNameOrAddress);

            uint macAddrLen = (uint)macAddr.Length;            

            Task SendArp = Task.Run(() =>
            {
                SendARP((int)IP.Address, 0, macAddr,
                ref macAddrLen);
            });
            SendArp.Wait();

            StringBuilder macAddressString = new StringBuilder();
            for (int i = 0; i < macAddr.Length; i++)
            {
                if (macAddressString.Length > 0)
                    macAddressString.Append(":");

                macAddressString.AppendFormat("{0:x2}", macAddr[i]);
            }            
            
            return (macAddressString.ToString().ToUpper());
            
        }

        public string GetMACAddressFromARP(string hostNameOrAddress)
        {

            if (!IsHostAccessible(hostNameOrAddress)) return null;       
            
            

            byte[] macAddr = new byte[6];


            IPAddress IP = IPAddress.Parse(hostNameOrAddress);
            

            uint macAddrLen = (uint)macAddr.Length;
            if (SendARP((int)IP.Address, 0, macAddr,
                ref macAddrLen) != 0)
                return null;

            

            StringBuilder macAddressString = new StringBuilder();
            for (int i = 0; i < macAddr.Length; i++)
            {
                if (macAddressString.Length > 0)
                    macAddressString.Append(":");

                macAddressString.AppendFormat("{0:x2}", macAddr[i]);
            }
            string result = macAddressString.ToString();
            return result.ToUpper();
        } // end GetMACAddressFromARP

        public async Task<bool> isHostAccessibleAsync(string hostNameOrAddress)
        {
            Ping PNG = new Ping();
            PingReply reply = await PNG.SendPingAsync(hostNameOrAddress);
            return reply.Status == IPStatus.Success;
        }
        
        public static bool IsHostAccessible(string hostNameOrAddress)
        {
            Ping ping = new Ping();
            PingReply reply = ping.Send(hostNameOrAddress, 1000);
            return reply.Status == IPStatus.Success;
        }



        public async Task<string[]> info(string hostNameOrAddress)
        {            
            Ping PNG = new Ping();

            try
            {
                PingReply PNGRPLY = await PNG.SendPingAsync((hostNameOrAddress), 500);             
                               
                if (PNGRPLY.Status == IPStatus.Success)
                {
                    string[] info = new string[4];
                    info[0] = hostNameOrAddress;
                    info[1] = await asyncGetMacAddressFromARP(hostNameOrAddress);
                    info[2] = (PNGRPLY.RoundtripTime.ToString() + " ms");
                    info[3] = await AsyncDetermineCompName(hostNameOrAddress);  
                    
                    return info;

                }
                else
                {
                    string[] info = new string[4];
                    info[0] = "";
                    info[1] = "";
                    info[2] = "";
                    info[3] = "";

                    return info;
                }
            }
            catch
            {
                string[] info = new string[4];
                info[0] = "";
                info[1] = "";
                info[2] = "";
                info[3] = "";


                return info;
            }
        }

     }
}
