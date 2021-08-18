using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Osservability.ReaderPrimary.Data;
using Osservability.ReaderSecondary.Data;
using System;

namespace Osservability.Writer
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
            var connectionStringVegetable = Environment.GetEnvironmentVariable("VegetableConnection");
            if (!string.IsNullOrEmpty(connectionStringVegetable))
            {
                services.AddDbContext<VegetableContext>(options =>
                    options.UseSqlServer(connectionStringVegetable));
            }

            var connectionStringFruit = Environment.GetEnvironmentVariable("FruitConnection");
            if (!string.IsNullOrEmpty(connectionStringFruit))
            {
                services.AddDbContext<FruitContext>(options =>
                    options.UseSqlServer(connectionStringFruit));
            }

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Osservability.Writer", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Osservability.Writer v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
