using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pavol_projjt_mvc_1
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            
            app.UseStaticFiles();

            //this wil go directly to wwwroot folder to open the index.html
            //app.UseFileServer();


            app.UseRouting();

            app.UseAuthorization();
            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.StartsWith("/tst"))
                {
                    context.Response.Redirect("Test/testing");
                }
                //else if (context.Request.Path.Value.StartsWith("/org"))
                //{
                //    context.Response.Redirect("Home/index");
                //}
               else {   await next(); }
                
            }); 
            app.Use(async (context, next) =>
            {
                 if (context.Request.Path.Value.StartsWith("/org"))
                {
                    context.Response.Redirect("Home/index");
                }
                else {   await next(); }
            });


            //app.Use(async (context, next) =>
            //{
            //     if (context.Request.Path.Value.StartsWith("/org"))
            //    {
            //        context.Response.Redirect("Home/index");
            //    }
            //    else {   await next(); }
            //});

            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //pattern: "{controller=Test}/{action=testing}");
            });

            //var bytes = Encoding.UTF8.GetBytes("Hello World");

            //app.Run(async (context) =>
            //{
            //    await context.Response.Body.WriteAsync(bytes);
            //});

        }
    }
}
