﻿// <auto-generated />
using BlogAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BlogAPI.Migrations
{
    [DbContext(typeof(BlogDbContext))]
    partial class BlogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlogAPI.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Url")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("BlogAPI.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("FileName")
                        .IsRequired();

                    b.Property<string>("FileType")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("MetaData");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Stream")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("BlogAPI.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BlogId");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Created");

                    b.Property<bool>("IsPublished");

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Subtitle");

                    b.Property<string>("Teaser");

                    b.Property<int>("Thumbnail");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BlogAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BlogId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("DisplayName")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<DateTime>("LastUpdated");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int>("Picture");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BlogAPI.Models.Post", b =>
                {
                    b.HasOne("BlogAPI.Models.Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId");
                });

            modelBuilder.Entity("BlogAPI.Models.User", b =>
                {
                    b.HasOne("BlogAPI.Models.Blog")
                        .WithMany("Owner")
                        .HasForeignKey("BlogId");
                });
#pragma warning restore 612, 618
        }
    }
}
