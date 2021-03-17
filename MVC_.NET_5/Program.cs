using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_.NET_5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
/*
 * Dependency Injection is an integral part of ASP.NET Core architecture
 * dotnet core injects objects of dependency classes  
 * through constructor by using built-in ioc container 
 *  => Dependency Injection using a container to receive all interface of object 
 *      dependencies which need to use in our program.
 *  => benefit : easy to maintain, when we want to change object dependency
 *               we just need to change the interface in DI container without
 *               changes to the rest of our program.
 */