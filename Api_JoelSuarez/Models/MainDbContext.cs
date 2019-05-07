using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Api_JoelSuarez.Models
{
    public class MainDbContext : DbContext
    {

        public MainDbContext()
        {

        }

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Person>().ToTable("person");
            builder.Entity<Person>().HasKey(p => p.name);
            //builder.Entity<Person>().Property(p => p.name).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Person>().Property(p => p.name).IsRequired().HasMaxLength(30);
            //builder.Entity<Person>().HasMany(p => p.Products).WithOne(p => p.Person).HasForeignKey(p => p.PersonId);

            builder.Entity<Person>().HasData
            (
                new Person { Id = 1, name = "Joel Suarez", isActive = false }, // Id set manually due to in-memory provider
                new Person { Id = 2, name = "Gustavo Suarez", isActive = false }
            );

            //builder.Entity<Product>().ToTable("Products");
            //builder.Entity<Product>().HasKey(p => p.Id);
            //builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            //builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            //builder.Entity<Product>().Property(p => p.QuantityInPackage).IsRequired();
            //builder.Entity<Product>().Property(p => p.UnitOfMeasurement).IsRequired();

            builder.Entity<Person>()
               .HasMany(p => p.projectsByPerson)
               //.WithOne(p => p.Person)
               .WithOne()
               .HasForeignKey(p => p.PersonId)
               .IsRequired();
        }

        public DbSet<Person> person { get; set; }
        public DbSet<ItemProject> itemProject { get; set; }
        public DbSet<ProjectItemTwo> ProjectItemTwo { get; set; }

    }
}
