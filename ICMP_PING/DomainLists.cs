using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace ICMP_PING
{
    class DomainLists
    {
        public static string[] moztop()
        {            
            var domainlist = new string[291];
            ServicePointManager.ServerCertificateValidationCallback += ValidateRemoteCertificate;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var spreadSheetStream = new MemoryStream(new WebClient().DownloadData("https://moz.com/top500/domains/csv/"));

            var parser = new TextFieldParser(spreadSheetStream);

            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            int count = 0;
            while (!parser.EndOfData)
            {
                //process row
                string[] fields = parser.ReadFields();
                foreach (string field in fields)
                {
                    if(field.Contains(".com") == true)
                    {
                        var parsedString = new StringBuilder();
                        foreach (char element in field)
                        {                            
                            char badchar = ('\x002f');
                            if(element != badchar)
                            {
                                parsedString.Append(element);
                            }                    

                        }                        
                        domainlist[count] += parsedString.ToString();
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }        



            

            return domainlist;
        }
        private static bool ValidateRemoteCertificate(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            // If the certificate is a valid, signed certificate, return true.
            if (error == System.Net.Security.SslPolicyErrors.None)
            {
                return true;
            }

            Console.WriteLine("X509Certificate [{0}] Policy Error: '{1}'",
                cert.Subject,
                error.ToString());

            return false;
        }


    }
}
