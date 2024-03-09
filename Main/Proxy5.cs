using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Main
{
    public class Proxy5
    {
        public async Task<bool> CheckProxy(string ip, string port, int timeOutSecond,CancellationToken token)
        {
            try
            {
                var proxy = new WebProxy
                {
                    Address = new Uri($"socks5://{ip}:{port}")
                };
                //proxy.Credentials = new NetworkCredential(); //Used to set Proxy logins. 
                var handler = new HttpClientHandler
                {
                    Proxy = proxy
                };
                var httpClient = new HttpClient(handler);
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:90.0) Gecko/20100101 Firefox/90.0");

                httpClient.Timeout = TimeSpan.FromSeconds(timeOutSecond);

                var response = await httpClient.GetAsync("https://youtube.com", token);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }

}
