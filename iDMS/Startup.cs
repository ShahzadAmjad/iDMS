using iDMS.Models;
using iDMS.Models.Audit.ElectricalCableCivilAudit;
using iDMS.Models.Audit.ElectricalCableTechnical;
using iDMS.Models.Audit.ElectricalDistributionAudit;
using iDMS.Models.Audit.ElectricalJointingAudit;
using iDMS.Models.Audit.EnvironmentalSiteAudit;
using iDMS.Models.Audit.GasTechnicalAudit;
using iDMS.Models.Audit.HealthSafetyAudit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iDMS
{
    public class Startup
    {
        private IConfiguration _config;

        public Startup(IConfiguration config)
        {
            _config = config;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(_config.GetConnectionString("iDMS_DBConnection"), sqlServerOptions => sqlServerOptions.CommandTimeout(60)));
            services.AddMvc(options => options.EnableEndpointRouting = false);


            //For SQL classes
            services.AddScoped<IHealthSafetyRepository, SQLHealthSafetyRepository>();
            services.AddScoped<IEnvironmentalSiteRepository, SQLEnvironmentalSiteRepository>();
            services.AddScoped<IElectricalCableCivilRepository, SQLElectricalCableCivilRepository>();
            services.AddScoped<IElectricalDistributionRepository, SQLElectricalDistributionRepository>();
            services.AddScoped<IElectricalJointingRepository, SQLElectricalJointingRepository>();

            services.AddScoped<IElectricalCableTechnicalRepository, SQLElectricalCableTechnicalRepository>();
            services.AddScoped<IGasTechnicalRepository, SQLGasTechnicalRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=HealthSafetyAudit}/{action=HealthSafetyAudit}");
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //});
        }
    }
}
