using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api_JoelSuarez.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Api_JoelSuarez
{
    public class BloggingContextFactory : IDesignTimeDbContextFactory<MainDbContext>
    {
        public MainDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MainDbContext>();
            optionsBuilder.UseNpgsql("server=localhost;user id=admin;password=admin;database=api_with_netcore");
            return new MainDbContext(optionsBuilder.Options);
        }


    }
}
