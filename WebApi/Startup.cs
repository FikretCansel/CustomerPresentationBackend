using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi
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
            services.AddSingleton<ICustomerInfoService, CustomerInfoManager>();
            services.AddSingleton<ISectorService, SectorManager>();
            services.AddSingleton<ICustomerInfoDal, EfCustomerInfoDal>();
            services.AddSingleton<IUsProductDal, EfUsProductDal>();
            services.AddSingleton<IUsProductService, UsProductManager>();
            services.AddSingleton<IUsProductImageDal, EfUsProductImageDal>();
            services.AddSingleton<IUsProductImageService, UsProductImageManager>();
            services.AddSingleton<ITagService, TagManager>();
            services.AddSingleton<ITagDal, EfTagDal>();
            services.AddSingleton<ICustomerTagDal, EfCustomerTagDal>();
            services.AddSingleton<IUsProductTagDal, EfUsProductTagDal>();
            services.AddSingleton<IAuthService, AuthManager>();
            services.AddSingleton<IUserDal, EfUserDal>();
            //services.AddCors(options => options.AddPolicy(ApiCorsPolicy, builder =>
            //{
            //    builder.WithOrigins("http://teknotest2.jettnet.com.tr").AllowAnyOrigin();
            //    //.AllowAnyMethod()
            //    //.AllowAnyHeader()
            //    //.AllowCredentials();
            //}));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApi", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi v1"));
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials());


            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}




//using Business.Abstract;
//using Business.Concrete;
//using DataAccess.Abstract;
//using DataAccess.Concrete.EntityFramework;
//using Microsoft.AspNetCore.Builder;
//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.HttpsPolicy;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
//using Microsoft.OpenApi.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace WebApi
//{
//    public class Startup
//    {
//        public Startup(IConfiguration configuration)
//        {
//            Configuration = configuration;
//        }

//        public IConfiguration Configuration { get; }


//        // This method gets called by the runtime. Use this method to add services to the container.
//        public void ConfigureServices(IServiceCollection services)
//        {


//            services.AddControllers();
//            services.AddSingleton<ICustomerInfoService, CustomerInfoManager>();
//            services.AddSingleton<ISectorService, SectorManager>();
//            services.AddSingleton<ICustomerInfoDal, EfCustomerInfoDal>();
//            services.AddSingleton<IUsProductDal, EfUsProductDal>();
//            services.AddSingleton<IUsProductService, UsProductManager>();
//            services.AddSingleton<IUsProductImageDal, EfUsProductImageDal>();
//            services.AddSingleton<IUsProductImageService, UsProductImageManager>();
//            services.AddSingleton<ITagService, TagManager>();
//            services.AddSingleton<ITagDal, EfTagDal>();
//            services.AddSingleton<ICustomerTagDal, EfCustomerTagDal>();
//            services.AddSingleton<IUsProductTagDal, EfUsProductTagDal>();

//            //services.AddCors(options => options.AddPolicy(ApiCorsPolicy, builder =>
//            //{
//            //    builder.WithOrigins("http://teknotest2.jettnet.com.tr").AllowAnyOrigin();
//            //    //.AllowAnyMethod()
//            //    //.AllowAnyHeader()
//            //    //.AllowCredentials();
//            //}));
//            services.AddCors();
//            services.AddSwaggerGen(c =>
//            {
//                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApi", Version = "v1" });
//            });
//        }

//        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
//        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//        {
//            if (env.IsDevelopment())
//            {
//                app.UseDeveloperExceptionPage();
//                app.UseSwagger();
//                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi v1"));
//            }

//            app.UseHttpsRedirection();

//            app.UseStaticFiles();

//            app.UseCors(builder => builder.WithOrigins("http://teknotest2.jettnet.com.tr", "http://localhost:3000").AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());

//            app.UseRouting();

//            //app.UseAuthorization();

//            app.UseEndpoints(endpoints =>
//            {
//                endpoints.MapControllers();
//            });
//        }
//    }
//}
