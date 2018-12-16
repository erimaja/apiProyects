using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;

namespace ContainerAppV2
{
    public class Program
    {
        static void Main()
        {
            /*
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                }
            }*/
            //string baseAddress = "http://" + localIP + ":5001/";

            // Running locally
            //string baseAddress = "http://localhost:9000/";
            // Running with docker
            string baseAddress = "http://*:9000/";


            // Start OWIN host 

            using (WebApp.Start<Startup>(url: baseAddress))

            {

                // Create HttpCient and make a request to api/values 
                HttpClient client = new HttpClient();
                var response = client.GetAsync(baseAddress ).Result;
                //var response = client.GetAsync(baseAddress + "/api/values").Result;
                Console.WriteLine(response);
                Console.WriteLine(response.Content.ReadAsStringAsync().Result);

                while (true)
                {
                    System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
                };
            }
            // Console.ReadLine();
        }
    }
        
    
}
