﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductiGraph.Data;

#nullable disable

namespace ProductiGraph.Migrations
{
    [DbContext(typeof(GraphassDbContext))]
    [Migration("20230305014603_AddMoreData")]
    partial class AddMoreData
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

                    b.Property<bool>("Completed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Completed = false,
                            Description = "I need a personal second brain to take care of my workflow efficiently",
                            Name = "Build Personal Productivity Machine",
                            Status = "Just created"
                        },
                        new
                        {
                            Id = 2,
                            Completed = false,
                            Description = "Learn about system design",
                            Name = "Mentoring with Sam",
                            Status = "Just created"
                        },
                        new
                        {
                            Id = 3,
                            Completed = false,
                            Description = "Thinking of making a gamified system for smart glasses",
                            Name = "Collab with Cayden",
                            Status = "Just created"
                        },
                        new
                        {
                            Id = 4,
                            Completed = false,
                            Description = "Learn about human centered design",
                            Name = "Research with Jina",
                            Status = "Just created"
                        },
                        new
                        {
                            Id = 5,
                            Completed = false,
                            Description = "We need to start getting UK ambassadors engaged with extra activities",
                            Name = "Plan Gold Engagement with Jennifer",
                            Status = "Just created"
                        },
                        new
                        {
                            Id = 6,
                            Completed = false,
                            Description = "GTA is the best grinding simulator",
                            Name = "Bring GTA UI to life",
                            Status = "Just created"
                        },
                        new
                        {
                            Id = 7,
                            Completed = false,
                            Description = "AI and ML is the future, time to pick up some skills",
                            Name = "Learn AI and ML",
                            Status = "Just created"
                        },
                        new
                        {
                            Id = 8,
                            Completed = false,
                            Description = "Get involved with the community",
                            Name = "Prepare content with Baki",
                            Status = "Just created"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
