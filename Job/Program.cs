using System;
using System.Configuration;
using System.Net;
using System.Threading;

namespace Job
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                var url = ConfigurationManager.AppSettings["url"];
                Console.WriteLine("{0} - Pinging {1}", DateTime.UtcNow, url);
                var client = WebRequest.CreateHttp(url);
                try
                {
                    using (var r = (HttpWebResponse)client.GetResponse())
                    {
                        Console.WriteLine("{0} - Returned status {1}", DateTime.UtcNow, r.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} - Something went wrong - {1}", DateTime.UtcNow, ex);
                }
                Thread.Sleep(TimeSpan.FromMinutes(1));
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}
