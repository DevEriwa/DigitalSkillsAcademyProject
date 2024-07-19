using Core.Config;
using Core.Db;
using Core.Models;
using Logic;
using Logic.Helpers;
using Logic.IHelpers;
using Logic.SmtpMailServices;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Net;

namespace Academy_App
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
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("StudentManagement")));
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 3;
                options.Password.RequiredUniqueChars = 0;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

            }).AddEntityFrameworkStores<AppDbContext>();

            services.AddSingleton<IEmailConfiguration>(Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
            services.AddSingleton<IGeneralConfiguration>(Configuration.GetSection("GeneralConfiguration").Get<GeneralConfiguration>());
            services.AddTransient<IEmailService, EmailService>();
            services.AddControllersWithViews();

            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = int.MaxValue;
                x.MultipartHeadersLengthLimit = int.MaxValue;
            });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
            });
            
            services.AddScoped<IUserHelper, UserHelper>()
                    .AddScoped<IEmailHelper, EmailHelper>()
                    .AddScoped<IDropdownHelper, DropdownHelper>()
                    .AddScoped<IApplicationHelper, ApplicationHelper>()
                    .AddScoped<ISuperAdminHelper, SuperAdminHelper>()
                    .AddScoped<IAdminHelper, AdminHelper>()
                    .AddScoped<IStudentHelper, StudentHelper>()
                    .AddScoped<IPaystackHelper, PaystackHelper>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStatusCodePages(async context =>
            {
                var response = context.HttpContext.Response;

                if (response.StatusCode == (int)HttpStatusCode.Unauthorized)
                {
                    response.Redirect("/Account/Login");
                }

                if (response.StatusCode == (int)HttpStatusCode.NotFound)
                {
                    response.Redirect("/Home/Error");
                }

                if (response.StatusCode == (int)HttpStatusCode.Forbidden)
                {
                    response.Redirect("/Home/Error");
                }

                if (response.StatusCode == (int)HttpStatusCode.BadGateway)
                {
                    response.Redirect("/Home/BadRequest");
                }

                if (response.StatusCode == (int)HttpStatusCode.InternalServerError)
                {
                    response.Redirect("/Home/Error");
                }


            });

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            UpdateDatabase(app);
        }



        private static void UpdateDatabase(IApplicationBuilder app)
        {
            AppHttpContext.Services = app.ApplicationServices;
            using (var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<AppDbContext>())
                {
                    context.Database.Migrate();
                }
            }
        }
    }
}
