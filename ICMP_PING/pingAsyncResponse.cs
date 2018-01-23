using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net.NetworkInformation;

namespace ICMP_PING
{
    public class pingAsyncResponse
    {
        public async Task<string[]> info(string domain)
        {

            TcpClient tcpclnt = new TcpClient();
            Ping PNG = new Ping();


            try
            {
                PingReply PNGRPLY = await PNG.SendPingAsync(("www." + domain), 2000);
                

                if (PNGRPLY.Status == IPStatus.Success)
                {
                    string[] info = new string[6];
                    info[0] = domain;
                    info[1] = PNGRPLY.Address.ToString();
                    info[2] = PNGRPLY.RoundtripTime.ToString();
                    info[3] = PNGRPLY.Options.Ttl.ToString();
                    info[4] = PNGRPLY.Options.DontFragment.ToString();
                    info[5] = PNGRPLY.Buffer.Length.ToString();
                    return info;

                }
                else
                {
                    string[] info = new string[6];
                    info[0] = domain;
                    info[1] = PNGRPLY.Address.ToString();
                    info[2] = "Failed";
                    info[3] = "";
                    info[4] = "";
                    info[5] = "";

                    return info;
                }
            }
            catch
            {
                string[] info = new string[6];
                info[0] = domain;
                info[1] = "Failed";
                info[2] = "";
                info[3] = "";
                info[4] = "";
                info[5] = "";
                return info;
            }





        }
        
    }
}
