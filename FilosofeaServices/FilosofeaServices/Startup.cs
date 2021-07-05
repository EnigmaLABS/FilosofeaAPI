
using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

using FilosofeaBusiness.Services;
using FilosofeaData.Context;
using FilosofeaData.Repositories;
using FilosofeaDomain.ServiceInterfaces;
using FilosofeaDomain.RepositoryInterfaces;
using FilosofeaDomain.DomainInterfaces;
using FilosofeaDomain.Entities;
using FilosofeaDomain.DTOInterfaces;
using FilosofeaDomain.DTO.Request;

namespace FilosofeaServices
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
              services.AddDbContext<FilosofeadbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            //Domain
            services.AddScoped<IAutor, Autor>();
            services.AddScoped<IEntrada, Entrada>();

            //Services
            services.AddScoped<IFiloService, FiloService>();
            services.AddScoped<IBlogService, BlogService>();

            //Repositories
            services.AddScoped<IFiloRepository, FiloRepository>();
            services.AddScoped<IBlogRepository, BlogRepository>();

            //DTO
            services.AddScoped<IPutEntradaRequest, PutEntradaRequest>();

            services.AddControllers();
            AddSwagger(services);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Filosofea API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void AddSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var groupName = "v1";

                options.SwaggerDoc(groupName, new OpenApiInfo
                {
                    Title = $"Filosofea {groupName}",
                    Version = groupName,
                    Description = "Filosofea API V1",
                    Contact = new OpenApiContact
                    {
                        Name = "Filosofea Company",
                        Email = string.Empty,
                        Url = new Uri("https://foo.com/"),
                    }
                });
            });
        }
    }
}
