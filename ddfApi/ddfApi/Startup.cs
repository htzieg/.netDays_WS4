using ddfApi.Filters;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;

namespace ddfApi
{
    public class Startup
    {
        private readonly IHostingEnvironment _environment;
        public Startup(IHostingEnvironment environment) //IHostingEnvironment: DI interface
        {
            _environment = environment ?? throw new ArgumentNullException(nameof(environment));
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddConsole(); //implementierung für iLogger
            }); //auch möglich KIBANA/ElasticSearch


            services.AddMvc(options =>
            {
                //options.Filters.Add(new ExceptionFilter(_environment));
                options.Filters.Add<ExceptionFilter>();
            });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("ddf-api", new Info() { Title = "DDF Demo", Version = "v1" });
                options.IncludeXmlComments("ddfApi.xml");
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(); //"use" immer nur Pipelines
            app.UseSwagger();
            app.UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/ddf-api/swagger.json", "DDF Demo"); });
        }
    }
}
