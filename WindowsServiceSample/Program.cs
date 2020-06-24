using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.EventLog;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WindowsServiceSample
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var isService = !(Debugger.IsAttached || args.Contains("--console"));
            var builder = CreateHostBuilder(args);
            if (isService)
            {
                await builder.Build().RunAsync();
            }
            else
            {
                await builder.RunConsoleAsync();
            }
            //CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging(
                    options => options.AddFilter<EventLogLoggerProvider>(level => level >= LogLevel.Information))
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<SmtpClient>((serviceProvider) =>
                    {
                        var config = serviceProvider.GetRequiredService<IConfiguration>();
                        return new SmtpClient()
                        {
                            Host = config.GetValue<String>("Email:Smtp:Host"),
                            Port = config.GetValue<int>("Email:Smtp:Port"),
                            Credentials = new NetworkCredential(
                                    config.GetValue<String>("Email:Smtp:Username"),
                                    config.GetValue<String>("Email:Smtp:Password")
                                ),
                            EnableSsl = config.GetValue<bool>("Email:Smtp:EnableSsl")
                        };
                    });

                    services.AddHostedService<Worker>()
                                    .Configure<EventLogSettings>(config =>
                                    {
                                        config.LogName = "Sample Service";
                                        config.SourceName = "Sample Service Source";
                                    });
                }).UseWindowsService();
    }
}
