﻿// <auto-generated />
using System;
using ApiJobs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace api_jobs.Migrations
{
    [DbContext(typeof(JobsContext))]
    partial class JobsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ApiJobs.Models.Category", b =>
                {
                    b.Property<Guid>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            CategoryId = new Guid("434bb0cc-afba-40f3-a872-980b562d7280"),
                            Description = "From nursing and medical practitioners to administrative roles, discover diverse positions that contribute to the well-being of individuals and communities",
                            Name = "Healthcare"
                        },
                        new
                        {
                            CategoryId = new Guid("434bb0cc-afba-40f3-a872-980b562d7279"),
                            Description = "From teaching roles to administrative positions, find your place in shaping the future. Explore diverse jobs that contribute to educational excellence and student success",
                            Name = "Education"
                        });
                });

            modelBuilder.Entity("ApiJobs.Models.Job", b =>
                {
                    b.Property<Guid>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(true);

                    b.Property<int>("JobType")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("PostingDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasDefaultValue(new DateTime(2023, 11, 12, 23, 46, 49, 380, DateTimeKind.Local).AddTicks(2826));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.HasKey("JobId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Job", (string)null);

                    b.HasData(
                        new
                        {
                            JobId = new Guid("434bb0cc-afba-40f3-a872-980b562d7290"),
                            CategoryId = new Guid("434bb0cc-afba-40f3-a872-980b562d7280"),
                            Description = "Nurse for the intensive care area in a large hospital in New York. At least 3 years of experience",
                            IsActive = false,
                            JobType = 0,
                            Location = "Miami, FL",
                            PostingDate = new DateTime(2023, 11, 12, 23, 46, 49, 380, DateTimeKind.Local).AddTicks(734),
                            Title = "Registered Nurse"
                        },
                        new
                        {
                            JobId = new Guid("434bb0cc-afba-40f3-a872-980b562d7291"),
                            CategoryId = new Guid("434bb0cc-afba-40f3-a872-980b562d7279"),
                            Description = "Math Teacher for High School. At least 2 years of experience",
                            IsActive = false,
                            JobType = 0,
                            Location = "Orlando, FL",
                            PostingDate = new DateTime(2023, 11, 12, 23, 46, 49, 380, DateTimeKind.Local).AddTicks(754),
                            Title = "Math Teacher"
                        });
                });

            modelBuilder.Entity("ApiJobs.Models.Job", b =>
                {
                    b.HasOne("ApiJobs.Models.Category", "Category")
                        .WithMany("Jobs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ApiJobs.Models.Category", b =>
                {
                    b.Navigation("Jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
