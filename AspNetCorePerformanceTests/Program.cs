using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace AspNetCorePerformanceTests
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel(options =>
                {
                    options.AddServerHeader = false;
                })
                .UseStartup<Startup>()
                .Build();

            await host.RunAsync();
        }
    }
}
