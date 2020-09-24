using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PortfolioWebApp.Models;
using PortfolioWebApp.Models.Interfaces;
using PortfolioWebApp.Models.UnitOfWork;

namespace PortfolioWebApp
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<DataContext>(Options =>
            {
                Options.UseSqlServer(configuration.GetConnectionString("DbCon"));
            });

            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));
            services.AddMvc().AddXmlSerializerFormatters();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseStatusCodePages();
                //app.UseStatusCodePagesWithRedirects("/Error/{0}");
                app.UseExceptionHandler("/Error");
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
              "defaultRoute",
              "{controller=Home}/{action=Index}/{id?}"
              );
            });
        }
    }
}
