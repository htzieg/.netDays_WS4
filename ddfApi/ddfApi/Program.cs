using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using ddfApi.Filters;

namespace ddfApi
{
    class Program
    {
        static void Main(string[] args)
        {
            var webhost = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>() //s. Startup.cs, refactoring
                .Build();
            webhost.Run();
            
        }
    }
}
