using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace VFrameworkBlazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //string comm = "/C terraform.exe init";
            //Process.Start("cmd.exe", comm);

            CreateHostBuilder(args).Build().Run();
            //VFrameworkBlazor.Utility.NameGenerator test = new("CAS", "SYS", "we", "dev", "w", "l", "web", "sql", "auth", "backlog");
            //Dictionary<string, string> dict = test.getDict();
            //Dictionary<string, string>.KeyCollection keys = dict.Keys;
            //Dictionary<string, string>.ValueCollection vals = dict.Values;

            //foreach (string key in keys)
            //{
            //    Console.WriteLine("Key: " + key + " value: " +  dict[key]);
            //}

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
