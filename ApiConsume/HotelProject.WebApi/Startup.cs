using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace HotelProject.WebApi
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
            //v15-17
            services.AddDbContext<Context>();
            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<IRoomService, RoomManager>();

            services.AddScoped<IServiceDal, EfServiceDal>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<IStaffDal, EfStaffDal>();//Data access layer katmaný IStaffDal görunce EfStaffDal bagla
            services.AddScoped<IStaffService, StaffManager>();//Service görünce Manager bagla , busýnes katmaný

            services.AddScoped<IsubscribeDal, EfSubscribeDal>();
            services.AddScoped<ISubscribeService, SubscribeManager>();

            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ITestimonialService, TestimonialManager>();
            //v15-17
            
            //v47
            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutservice, AboutManager>();
            //v47
            //v30
            services.AddAutoMapper(typeof(Startup));
            //v30
            //57
            services.AddScoped<IBookingDal, EfBookingDal>();
            services.AddScoped<IBookingService, BookingManager>();
            //v57
            //v91
            services.AddScoped<IContactDal, EfContactDal>();
            services.AddScoped<IContactService, ContactManager>();
            //v91

            //v96
            services.AddScoped<IGuestDal, EfGuestDal>();
            services.AddScoped<IGuestService, GuestManager>();
            //v96
            //v105
            services.AddScoped<ISendMessageDal, EfSendMessageDal>();
            services.AddScoped<ISendMessageService, SendMessageManager>();
            //v1054

            //131
            services.AddScoped<ICategoryContactMessageDal, EfCategoryContactMessageDal>();
            services.AddScoped<ICategoryContactMessageService, CategoryContactMessageManager>();
            //131

            //138
            services.AddScoped<IWorkLocationDal, EfWorkLocationDal>();
            services.AddScoped<IWorkLocationService, WorkLocationManager>();
            //138
            //140
            services.AddScoped<IAppUserDal, EfAppUserDal>();
            services.AddScoped<IAppUserService, AppUserManager>();
            //110

            //v21
            services.AddCors(opts =>
            {
                opts.AddPolicy("OtelApiCors", opts =>
                {
                    opts.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                });
            });
            //v21  api ýleýlgýlý ýzýnlerý yapýyoruz burda asagýdada burda yaptýgýmýz uyguluyoruz
            
            //141 burda apýden ýlýskýlý dosya cekersen apýden bu kodu kulanýyoruz
            services.AddControllers().AddNewtonsoftJson(options=>options.SerializerSettings.ReferenceLoopHandling=Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            //141
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HotelProject.WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "HotelProject.WebApi v1"));
            }

            app.UseRouting();
            //v21
            app.UseCors("OtelApiCors");
            //v21

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
