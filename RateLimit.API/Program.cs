using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using AspNetCoreRateLimit;

namespace RateLimit.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = CreateHostBuilder(args).Build();
            // Get service ilgili servis yok ise geriye "Null" d�ner, GetRequiredService kulland���m�z zaman ise iligili servis yok ise geriye
            //bir hata f�rlatmaktad�r.
            var IpPolicy = webHost.Services.GetRequiredService<IIpPolicyStore>();
            IpPolicy.SeedAsync().Wait();
            webHost.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
