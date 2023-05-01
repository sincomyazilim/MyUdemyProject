using HotelProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.GuestDto;
using HotelProject.WebUI.ValidationRules.GuestValidationRules;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

namespace HotelProject.WebUI
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
            //41
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
            //burda context bagladýký webuý DataAccessLayer katmanýn aulasýyor
            //41
            //v23
            services.AddHttpClient();
            //v23
            //services.AddControllersWithViews();//99-100 buda sonuna  AddFluentValidation eklýyoruz
            services.AddTransient<IValidator<AddGuestDto>, AddGuestValidator>();//100 eklýyorsu ki karsýlastýrmakýcýn
            services.AddTransient<IValidator<UpdateGuetDto>, UpdateGuestValidator>();//101 eklýyorsu ki karsýlastýrmakýcýn
            services.AddControllersWithViews().AddFluentValidation();
            //v35
            services.AddAutoMapper(typeof(Startup));
            //v35

            //122
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();//bu kýsýmda butun projeye gýrememe  yetkýsý verýlýyor

                config.Filters.Add(new AuthorizeFilter(policy));
            });
            //123
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                options.LoginPath = "/Login/Index/";
            });
            //123
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
                app.UseExceptionHandler("/Default/Error");
            }
            //125
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404","?code={0}");
            app.UseHttpsRedirection();
            //125
            app.UseStaticFiles();

            //122
             app.UseAuthorization();
             app.UseAuthentication();
           
            //122

            app.UseRouting();

           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Default}/{action=Index}/{id?}");
            });
        }
    }
}
