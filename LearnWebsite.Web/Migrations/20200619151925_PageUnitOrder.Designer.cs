﻿// <auto-generated />
using System;
using LearnWebsite.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LearnWebsite.Web.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200619151925_PageUnitOrder")]
    partial class PageUnitOrder
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LearnWebsite.Web.Models.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("LearnWebsite.Web.Models.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UrlName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Viewed")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            Created = new DateTime(2020, 6, 19, 18, 19, 23, 172, DateTimeKind.Local).AddTicks(5920),
                            Description = "Learn the basics of web development using asp.net core 3.1, ef core and bootstrap",
                            DisplayName = "ASP.NET Core Mvc",
                            ImageSrc = "data:image/png;base64,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",
                            Viewed = 0
                        });
                });

            modelBuilder.Entity("LearnWebsite.Web.Models.Entities.CoursePage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HtmlContent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InUnitOrder")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnitId");

                    b.ToTable("Pages");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            HtmlContent = "<h3>Welcome to our course!<h3><p>Let's begin by setting up our development envirnoment. We are going to use the Visual Studio 2019 IDE to develope our web application.</p>",
                            InUnitOrder = 0,
                            Title = "Setting Up",
                            UnitId = -1
                        });
                });

            modelBuilder.Entity("LearnWebsite.Web.Models.Entities.CourseUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InCourseOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Units");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CourseId = -1,
                            DisplayName = "Getting Started",
                            InCourseOrder = 0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LearnWebsite.Web.Models.Entities.CoursePage", b =>
                {
                    b.HasOne("LearnWebsite.Web.Models.Entities.CourseUnit", "Unit")
                        .WithMany("Pages")
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnWebsite.Web.Models.Entities.CourseUnit", b =>
                {
                    b.HasOne("LearnWebsite.Web.Models.Entities.Course", "Course")
                        .WithMany("Units")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("LearnWebsite.Web.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("LearnWebsite.Web.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnWebsite.Web.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("LearnWebsite.Web.Models.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
