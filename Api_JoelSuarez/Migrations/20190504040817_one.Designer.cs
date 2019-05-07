﻿// <auto-generated />
using System;
using Api_JoelSuarez.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Api_JoelSuarez.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20190504040817_one")]
    partial class one
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Api_JoelSuarez.Models.ItemProject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<TimeSpan>("Creation_Date");

                    b.Property<int>("UserId");

                    b.Property<bool>("isActive");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.HasIndex("name");

                    b.ToTable("itemProject");
                });

            modelBuilder.Entity("Api_JoelSuarez.Models.Person", b =>
                {
                    b.Property<string>("name")
                        .ValueGeneratedOnAdd();

                    b.Property<TimeSpan>("Creation_Date");

                    b.Property<DateTime>("creation_information");

                    b.Property<bool>("isActive");

                    b.Property<string>("last_name");

                    b.Property<string>("password");

                    b.HasKey("name");

                    b.ToTable("person");
                });

            modelBuilder.Entity("Api_JoelSuarez.Models.ProjectItemTwo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<TimeSpan>("Creation_Date");

                    b.Property<string>("Owner");

                    b.Property<bool>("isActive");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.HasIndex("Owner");

                    b.ToTable("ProjectItemTwo");
                });

            modelBuilder.Entity("Api_JoelSuarez.Models.ItemProject", b =>
                {
                    b.HasOne("Api_JoelSuarez.Models.Person", "Owner")
                        .WithMany("personProjects")
                        .HasForeignKey("name");
                });

            modelBuilder.Entity("Api_JoelSuarez.Models.ProjectItemTwo", b =>
                {
                    b.HasOne("Api_JoelSuarez.Models.Person", "PersonOwner")
                        .WithMany()
                        .HasForeignKey("Owner");
                });
#pragma warning restore 612, 618
        }
    }
}
