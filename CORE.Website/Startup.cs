using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CORE.Data;
using CORE.Data.Infrastructor;
using CORE.Service.EF;
using CORE.Service.IF;
using CORE.Website.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CORE.Website
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
            services.AddDbContext<COREDbContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"),
               o => o.MigrationsAssembly("CORE.Data")));

            //services.AddTransient(typeof(IUnitOfWork), typeof(EFUnitOfWork));
            services.AddTransient(typeof(IRepository<,>), typeof(Repository<,>));
            services.AddTransient(typeof(IReadOnlyRepository), typeof(ReadOnlyRepostory));
            services.AddTransient<IBlogService, BlogService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IMDocumentService, MDocumentService>();
            services.AddTransient<IPricingService, PricingService>();
            services.AddTransient<ISettingService, SettingService>();


            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IViewEnginerService, ViewEnginerService>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });


            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);

                options.LoginPath = "/Customer/Login";
                options.AccessDeniedPath = "/Customer/Login";
                options.SlidingExpiration = true;
            });


            //services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            //        .AddCookie();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
             .AddCookie(options =>
             {
                 options.LoginPath = new PathString("/dang-nhap.html");
                 options.ReturnUrlParameter = "RequestPath";
                 options.Events.OnRedirectToLogin = (context) =>
                 {
                     context.Response.StatusCode = 401;
                     return Task.CompletedTask;
                 };
             });

            ConfigureSignalR(services);
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void ConfigAuthCustomer(IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie("cookies", options =>
            {
                options.AccessDeniedPath = new PathString("/dang-nhap.html");
                // access
                options.Cookie = new CookieBuilder
                {
                    //Domain = "",
                    HttpOnly = true,
                    Name = ".aspNetCore.Security.Cookie",
                    Path = "/",
                    SameSite = SameSiteMode.Lax,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest
                };
                options.Events = new CookieAuthenticationEvents
                {
                    OnSignedIn = context =>
                    {
                        Console.WriteLine("{0} - {1}: {2}", DateTime.Now,
                            "OnSignedIn", context.Principal.Identity.Name);
                        return Task.CompletedTask;
                    },
                    OnSigningOut = context =>
                    {
                        Console.WriteLine("{0} - {1}: {2}", DateTime.Now,
                            "OnSigningOut", context.HttpContext.User.Identity.Name);
                        return Task.CompletedTask;
                    },
                    OnValidatePrincipal = context =>
                    {
                        Console.WriteLine("{0} - {1}: {2}", DateTime.Now,
                            "OnValidatePrincipal", context.Principal.Identity.Name);
                        return Task.CompletedTask;
                    }
                };
                //options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.LoginPath = new PathString("/dang-nhap.html");
                options.ReturnUrlParameter = "RequestPath";
                options.SlidingExpiration = true;
            });
        }

        public void ConfigureSignalR(IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("CorsPolicy",
               builder =>
               {
                   builder.AllowAnyMethod()
                       .AllowAnyHeader()
                       .WithOrigins("http://localhost:3000")
                       .AllowCredentials();
               }));
            services.AddSignalR();
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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();
            app.UseCors(x => x
             .AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader());

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");

            //     //endpoints.MapAreaControllerRoute(
            //     //   name: "areaRoute",
            //     //   areaName: "Admin",
            //     //   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(name: "areaRoute",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
