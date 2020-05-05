using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Actio.Common.Commands;
using Actio.Common.Mongo;
using Actio.Common.RabbitMq;
using Actio.Services.Activities.Repositories;
using Actio.Services.Activities.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Actio.Services.Activities.Domain.Repositories;
using Actio.Services.Activities.Handlers;

namespace Actio.Services.Activities
{
    public class Startup
    {
        //public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        //private readonly IDatabaseInitializer _databaseInitializer;
        public Startup(IConfiguration configuration)
        {
            //_databaseInitializer = databaseInitializer;
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().AddControllersAsServices();
            //established a connection and configured our service bus
            services.AddRabbitMq(Configuration);
            //add mongo db
            services.AddMongoDB(Configuration);
            
            //add handler
            // commad will be handled by service while, api will handle the events
            services.AddSingleton<ICommandHandler<CreateActivity>, CreateActivityHandler>();
            // added Repository Implementation
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IActivityRepository, ActivityRepository>();
            services.AddTransient<IDatabaseSeeder, CustomMongoSeeder>();
            services.AddScoped<IActivityService, ActivityService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //app.ApplicationServices.GetService<IDatabaseInitializer>().InitializeAsync();
            //app.UseMvc();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                endpoints.MapControllerRoute(name: "home",
                pattern: "home/{*article}",
                defaults: new { controller = "Home", action = "New" });
            });
        }
    }
}

