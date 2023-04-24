using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Operator.네트워크_프로그래밍
{
    internal class WebClientDemo
    {
        /*static void Main() 
        {
        WebClient client = new WebClient();

            string google = client.DownloadString("http://www.google.co.kr");
            *//*Console.WriteLine(  google );*//*
            Console.WriteLine(  "Google : " + google.Substring(0,10));

            client.DownloadStringAsync(new Uri("http://www.dotnetKorea.com"));
            client.DownloadStringCompleted += Client_DownloadStringCompleted;
            Thread.Sleep(3000);

        }

        private static void Client_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            string r = e.Result.Replace("\n","").Substring(0,10);
            Console.WriteLine(  $"DotNetKorea: {r}");
        }*/
    }
}
