using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using projeto_escola.DTO;
using projeto_escola.Model;
using Serilog;
using Serilog.Events;
using ILogger = Serilog.ILogger;

namespace projeto_escola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Aluno, AlunoDTO>();
            });

            var mapper = configuration.CreateMapper();

            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
               .Enrich.FromLogContext()
               .WriteTo.Console()
               .WriteTo.Seq("http://localhost:5341")
               .CreateLogger();

            Log.Information("Starting aplication...");


            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    webBuilder.UseSerilog();
                });
    }
}
