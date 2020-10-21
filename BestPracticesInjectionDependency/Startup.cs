using BestPracticesInjectionDependency.Services.BestPractice1;
using BestPracticesInjectionDependency.Services.BestPractice2;
using BestPracticesInjectionDependency.Services.BestPractice3;
using BestPracticesInjectionDependency.Services.BestPractice4;
using BestPracticesInjectionDependency.Services.BestPractice5;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BestPracticesInjectionDependency
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

            services.AddTransient<IBestPractice1Service, BestPractice1Service>();
            services.AddTransient<IBestPractice2Service, BestPractice2Service>();
            services.AddTransient<IBestPractice3Service, BestPractice3Service>();
            services.AddTransient<IBestPractice4Service, BestPractice4Service>();
            services.AddSingleton<IBestPractice5Service, BestPractice5Service>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
