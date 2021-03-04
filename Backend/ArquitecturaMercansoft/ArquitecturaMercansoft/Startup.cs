


using DataAccess.ClienteDAL;
using DataAccess.ModeloDatos;
using DataAccess.ModeloDatosCodeFirst;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.ClienteBI;
using AutoMapper;
using Transversal.AutoMapper;
using Seguridad.Filters;
using Business.SeguridadBI;
using DataAccess.SeguridadDAL;

namespace ArquitecturaMercansoft
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        readonly string MyAllowSpecificOrigins = "*";
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200",
                                                          "http://www.contoso.com");
                                  });
            });

            services.AddControllers();
            services.AddTransient<IClienteBI, ClienteBI>();
            services.AddTransient<IClienteDAL, ClienteDAL>();
            services.AddTransient<ISeguridadBI, SeguridadBI>();
            services.AddTransient<ISeguridadDAL, SeguridadDAL>();
            services.AddDbContext<arquitecturamercansoft2Context>();
            services.AddDbContext<ArquitecturaMercansoftContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("ArquitecturaMercansoftDataBase")));
            // Auto Mapper Configurations
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ArquitecturaMercansoft", Version = "v1" });
            });

            //Filtro en el proyecto
            services.AddMvc(options =>
            {
                // by instance  
                options.Filters.Add(new SecurityTokenFilter(new SeguridadBI()));
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ArquitecturaMercansoft v1"));
            }

            app.UseCors(builder => builder
                         .AllowAnyOrigin()
                         .AllowAnyMethod()
                         .AllowAnyHeader());

            
            app.UseExceptionHandler("/error");
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


        }
    }
}
