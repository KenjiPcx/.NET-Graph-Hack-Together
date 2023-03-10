// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductiGraph.Data;

#nullable disable

namespace ProductiGraph.Migrations
{
    [DbContext(typeof(GraphassDbContext))]
    [Migration("20230306221659_UpdateSeedProjects")]
    partial class UpdateSeedProjects
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("ProductiGraph.Data.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "A hackathon to learn about Microsoft Graph using .NET",
                            Name = "Microsoft Graph .NET hackathon"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Microsoft's annual hackathon to build a solution using Microsoft Azure",
                            Name = "Microsoft Imagine Cup"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Do cool things with Microsoft as a student",
                            Name = "Microsoft Learn Student Ambassadors"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Get advice about anything from a Microsoft MVP",
                            Name = "Microsoft MVP Mentoring"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Build something for the Microsoft Community",
                            Name = "Social Impact Project"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
