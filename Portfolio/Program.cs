using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Ooui;
using Portfolio.Views;
using System;
using Portfolio.Call;

namespace Portfolio {
    public class Program {
        public static void Main (string[] args) {

            Xamarin.Forms.Forms.Init();

            OverviewCall overview = new OverviewCall();

            overview.Publish();
            UI.Present(overview.Path);

            // Don't exit the app until someone hits return
            Console.ReadLine ();CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder (string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
