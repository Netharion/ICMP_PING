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

        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        static extern int SendARP(int DestIP, int SrcIP, byte[] pMacAddr,
            ref uint PhyAddrLen);

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
        
        private static bool IsHostAccessible(string hostNameOrAddress)
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
                    info[1] = GetMACAddressFromARP(hostNameOrAddress);
                    info[2] = PNGRPLY.RoundtripTime.ToString();
                    info[3] = DetermineCompName(hostNameOrAddress);  
                    
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
