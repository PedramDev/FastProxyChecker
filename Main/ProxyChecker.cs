using SocksSharp;
using SocksSharp.Proxy;

namespace Main
{
    public class ProxyChecker
    {
        private const string AddressToCheck = "https://youtube.com";

        public enum ProxyType
        {
            Https,
            Socks4,
            Socks5,
        }

        public Task<bool> CheckProxy(ProxyType type, string ip, int port, int timeOutSecond, CancellationToken token)
        {
            return type switch
            {
                ProxyType.Https => CheckProxy<Http>(ip, port, timeOutSecond, token),
                ProxyType.Socks4 => CheckProxy<Socks4>(ip, port, timeOutSecond, token),
                ProxyType.Socks5 => CheckProxy<Socks5>(ip, port, timeOutSecond, token),
                _ => Task.FromResult(false),
            };
        }

        private async Task<bool> CheckProxy<Type>(string ip, int port, int timeOutSecond, CancellationToken token) where Type : IProxy

        {
            var settings = new ProxySettings()
            {
                Host = ip, 
                Port = port,
                ConnectTimeout = timeOutSecond,
            };

            using var proxyClientHandler = new ProxyClientHandler<Type>(settings);
            using var httpClient = new HttpClient(proxyClientHandler);

            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
            "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:90.0) Gecko/20100101 Firefox/90.0");

            try
            {
                var response = await httpClient.GetAsync(AddressToCheck,token);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
