using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_JoelSuarez.Domain.Repositories;
using Api_JoelSuarez.Domain.Services;
using Api_JoelSuarez.Models;
using Api_JoelSuarez.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Api_JoelSuarez
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            //Api Implementation
            services.AddDbContext<MainDbContext>(options =>
            {
                options.UseNpgsql("server=localhost;user id=admin;password=admin;database=api_with_netcore");
            });

            services.AddScoped<IPersonRepository, PersonRepository>();
            services.AddScoped<IProjectsService, ProjectsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
