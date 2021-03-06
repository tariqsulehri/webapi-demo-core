using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using WebApiDemo.Infrastructure.IRepositories;
using WebApiDemo.Infrastructure.IRepositories.Generic;
using WebApiDemo.Infrastructure.Repositories;
using WebApiDemo.Infrastructure.Repositories.Generic;

namespace WebApiDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Demo Application",
                    Description = "A Demo Application to Test Api Responses",
                    TermsOfService = new Uri("https://tkxel.com"),
                    Contact = new OpenApiContact
                    {
                        Name = "Mubashar Khan",
                        Email = "services@tkxel.com",
                        Url = new Uri("https://tkxel.com/"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Tkxel",
                        Url = new Uri("https://tkxel.com/"),
                    }
                });

            });

            services.AddSingleton<ICountryRepository, CountryRepository>();
            services.AddSingleton<ICustomerRepository, CustomerRepository>();
            services.AddSingleton<ICallRepository, PhoneCallRepository>();
            services.AddSingleton<IRegionRepository, RegionRepository>();
            services.AddSingleton<ITelcoRepository, TelcoRepository>();

            //Generic Injections
            services.AddSingleton<IApiResponseRepository, ApiResponseRepository>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment() || env.IsProduction() || env.IsStaging())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Web Api Demo v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
