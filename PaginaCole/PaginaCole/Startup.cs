using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using PaginaCole.Datos;
using PaginaCole.Helper;
using PaginaCole.Interfaces;
using PaginaCole.Services;
using PaginaCole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using PaginaCole.Repository;
//using PaginaCole.Repository;

namespace PaginaCole
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
            //services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddMvc();
            services.AddScoped<IHorarioRepository, HorarioRepository>();
            services.AddScoped<IPhotoService, PhotoService>();
            services.AddScoped<IEmailService, EmailService>();
            services.Configure<CloudinarySettings>(Configuration.GetSection("CloudinarySettings"));
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(86400);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            services.TryAddSingleton<IHttpContextAccessor, Microsoft.AspNetCore.Http.HttpContextAccessor>();

            var coneccion = @"Data Source=(local);Database=db_cole;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<DBContext>(options => options.UseSqlServer(coneccion));
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseStatusCodePagesWithRedirects("/Home/Error?statusCode={0}");

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
