using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using GraphQl.Data;

namespace GraphQl
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddPooledDbContextFactory<Digitallabs_CI_DEVELOPContext>(
                    (s, o) => o
                    .UseSqlServer("data source=ATADIBMADEMOS.cloudapp.net,49206;password=#SA#2013sw2;initial catalog=DigitalLabs_CI_DEVELOP;user id=ambsa;persist security info=true")
                    .EnableSensitiveDataLogging()
                    .UseLoggerFactory(s.GetRequiredService<ILoggerFactory>())
                )
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddFiltering()
                .AddSorting()
                .AddProjections();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
            });
        }
    }
}
