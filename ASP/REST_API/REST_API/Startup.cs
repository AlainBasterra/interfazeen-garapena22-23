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
using Microsoft.EntityFrameworkCore;
using REST_API.Data;
using REST_API.Services;
using System.Text.Json.Serialization;

namespace REST_API
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
            //nik gehituta json "a possible json object cycle was detected"
            //using bat jarrita goian: using System.Text.Json.Serialization;
            services.AddControllers().AddJsonOptions(x =>
               x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "REST_API", Version = "v1" });
            });

            //Gure konexioa injektatzen dugu
            services.AddDbContext<WineShopDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("WineShopConnection")));

            //Zerbitzuak injektatzeko
            services.AddScoped<IArdoaService, ArdoaService>();
            services.AddScoped<IEskualdeaService, EskualdeaService>();
            services.AddScoped<ISaskiaAleaService, SaskiaAleaService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "REST_API v1"));
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
