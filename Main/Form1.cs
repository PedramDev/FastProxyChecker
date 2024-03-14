using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace Main
{
    public partial class Form1 : Form
    {
        private ConcurrentBag<Sock5Model> Socks5List;
        // Define the cancellation token.
        CancellationTokenSource _source;
        private static int _proxyRemains = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            _source = new CancellationTokenSource();
            CancellationToken cancelToken = _source.Token;

            var timer_stop_watch = new Stopwatch();

            var checker = new ProxyChecker();

            var options = new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount, CancellationToken = cancelToken };
            await Parallel.ForEachAsync(Socks5List, options, async (socks, token) =>
            {
                await checker.CheckProxy(ProxyChecker.ProxyType.Socks4, socks.Host, int.Parse(socks.Port), 10000, token).ContinueWith(t =>
                {
                    if (t.Result)
                    {
                        ThreadHelperClass.SetAppendTextarea(this, rtx_good, (Environment.NewLine + socks.ToString()));
                    }
                    else
                    {
                        ThreadHelperClass.SetAppendTextarea(this, rtx_bad, (Environment.NewLine + socks.ToString()));
                    }
                    ThreadHelperClass.SetText(this, lblRemains, (--_proxyRemains).ToString());
                });
            });


            timer_stop_watch.Stop();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var proxies = await File.ReadAllLinesAsync(openFileDialog1.FileName);
                Socks5List = [];

                Socks5List = new ConcurrentBag<Sock5Model>(proxies.Select(c =>
                new Sock5Model
                {
                    Host = IP().Match(c).Value,
                    Port = Port().Match(c).Value
                }
                )
                .ToList());

                lblTotalProxyCount.Text = "Proxies : " + proxies.Length.ToString();
                lblRemains.Text = proxies.Length.ToString();
                _proxyRemains = proxies.Length;
                btnStart.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rtx_bad.Text = string.Join(Environment.NewLine, Socks5List.Where(c => c.IsGood == false).Select(c => c.ToString()));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            _source.Cancel();
        }

        [GeneratedRegex(@"(?<=:)\d+")]
        private static partial Regex Port();
        [GeneratedRegex(@"\d+\.\d+\.\d+\.\d+")]
        private static partial Regex IP();
    }

    public class Sock5Model
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public bool? IsGood { get; set; }

        public override string ToString()
        {
            return Host + ":" + Port;
        }
    }
}
