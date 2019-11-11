using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace StarMatrix.Models
{
    public class Ipaddress
    {
        public static string GetIpaddress()
        {
            string ipaddress;
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            ipaddress = Dns.GetHostByName(hostName).AddressList[0].ToString(); // Get the IP  
            return ipaddress;
        }
    }
}
