using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DUSCoreTraining.Models;
using DUSCoreTraining.Pages.Modul05;
using DUSCoreTraining.Pages.Modul10;
using DUSCoreTraining.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DUSCoreTraining
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession(options => options.Cookie.HttpOnly = true);

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddSessionStateTempDataProvider(); ;
            services.AddSingleton<Dumm>();
            services.AddResponseCaching();
            services.AddDbContext<ModelRechnung>(options =>
                 options.UseSqlServer(Configuration.GetConnectionString("Rechnung")));
            services.AddSignalR();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            AppDomain.CurrentDomain.SetData("wwwpath", env.ContentRootPath);

            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute("hannes", "{controller=Hannes}/{action=Index}/{id?}");
            }
                );


            app.MapWhen(context => context.Request.Path.ToString().Contains("Imageloader.ashx"),
                appBranch =>
                {
                    appBranch.UseImageLoader();
                });

            app.ApplicationServices.GetService<Dumm>().MyProperty = 0;

            app.UseResponseCaching();
            app.UseSignalR(routes =>
            routes.MapHub<DemoHub>("/DemoHub"));
        }

    }
}
