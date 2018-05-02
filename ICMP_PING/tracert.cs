using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using Newtonsoft.Json;
using System.Globalization;

namespace ICMP_PING
{
    class tracert
    {
        private const string Data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

        public static IEnumerable<IPAddress> GetTraceRoute(string hostNameOrAddress)
        {
            return GetTraceRoute(hostNameOrAddress, 1);
        }
        private static IEnumerable<IPAddress> GetTraceRoute(string hostNameOrAddress, int ttl)
        {
            Ping pinger = new Ping();
            PingOptions pingerOptions = new PingOptions(ttl, true);
            int timeout = 10000;
            byte[] buffer = Encoding.ASCII.GetBytes(Data);
            PingReply reply = default(PingReply);

            reply = pinger.Send(hostNameOrAddress, timeout, buffer, pingerOptions);

            List<IPAddress> result = new List<IPAddress>();
            if (reply.Status == IPStatus.Success)
            {
                result.Add(reply.Address);
            }
            else if (reply.Status == IPStatus.TtlExpired || reply.Status == IPStatus.TimedOut)
            {
                //add the currently returned address if an address was found with this TTL
                if (reply.Status == IPStatus.TtlExpired) result.Add(reply.Address);
                //recurse to get the next address...
                IEnumerable<IPAddress> tempResult = default(IEnumerable<IPAddress>);
                tempResult = GetTraceRoute(hostNameOrAddress, ttl + 1);
                result.AddRange(tempResult);
            }
            else
            {
                //failure 
            }

            return result;
        }
        

        public static IPGeoLoc BuildIPData(string ip)
        {
            IPGeoLoc ipInfo = new IPGeoLoc();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IPGeoLoc>(info);

            }
            catch (Exception)
            {
                ipInfo = null;
            }

            return ipInfo;
        }       

        public static StringBuilder[] IPGEOINFO(IPAddress trace)
        {
            var IPINFO = new StringBuilder[5];

            try
            {
                int SecondPoint = 0;
                var IPdata = tracert.BuildIPData(trace.ToString());

                

                var Result = tracert.BuildIPData(trace.ToString());

                var longitude = new StringBuilder();
                var lattitude = new StringBuilder();

                foreach (char num in Result.Loc)
                {
                    if (SecondPoint < 1)
                    {
                        if (num.ToString() == ",")
                        {
                            SecondPoint++;
                        }
                        else
                        {
                            longitude.Append(num);
                        }
                    }
                    else
                    {
                        lattitude.Append(num);
                    }
                }

                IPINFO[0] = (longitude);
                IPINFO[1] = (lattitude);

                //Misc Data below added to stringbuilder array
                var location = new StringBuilder((Result.Region) + (", ") + (Result.Country));
                var org = new StringBuilder(Result.Org);
                var ip = new StringBuilder(Result.Ip);                
                IPINFO[2] = (ip);
                IPINFO[3] = (org);
                IPINFO[4] = (location);



            }
            catch
            {
                IPINFO[0] = null;
            }

            return IPINFO;

        }

        

    }
}

    

