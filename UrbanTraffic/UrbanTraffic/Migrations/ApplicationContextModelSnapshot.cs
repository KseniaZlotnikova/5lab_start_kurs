﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using UrbanTraffic.Models;

namespace UrbanTraffic.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
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
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("UrbanTraffic.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MiddleName");

                    b.Property<string>("Name");

                    b.Property<string>("Position");

                    b.Property<string>("Surname");

                    b.Property<int>("WorkExperience");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("UrbanTraffic.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("UrbanTraffic.Routes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Distance");

                    b.Property<bool>("ExpressRoute");

                    b.Property<int>("StoppingId");

                    b.Property<float>("TravelTime");

                    b.HasKey("Id");

                    b.HasIndex("StoppingId");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("UrbanTraffic.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("ArrivaTime");

                    b.Property<string>("DayOfTheWeek");

                    b.Property<int>("TypeOfTransportId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("TypeOfTransportId");

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("UrbanTraffic.Stopping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("ControlRoom");

                    b.Property<bool>("EndingStation");

                    b.Property<string>("Name");

                    b.Property<int>("TypeOfTransportId");

                    b.HasKey("Id");

                    b.HasIndex("TypeOfTransportId");

                    b.ToTable("Stopping");
                });

            modelBuilder.Entity("UrbanTraffic.TransportService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Change");

                    b.Property<DateTime>("Date");

                    b.Property<int>("EmployeesId");

                    b.Property<int>("RoutesId");

                    b.Property<int?>("TypeOfTransportId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("RoutesId");

                    b.HasIndex("TypeOfTransportId");

                    b.ToTable("TransportService");
                });

            modelBuilder.Entity("UrbanTraffic.TypeOfTransport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TypeOfTransport");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("UrbanTraffic.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("UrbanTraffic.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanTraffic.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("UrbanTraffic.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UrbanTraffic.Routes", b =>
                {
                    b.HasOne("UrbanTraffic.Stopping", "Stopping")
                        .WithMany("Routes")
                        .HasForeignKey("StoppingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UrbanTraffic.Schedule", b =>
                {
                    b.HasOne("UrbanTraffic.TypeOfTransport", "TypeOfTransport")
                        .WithMany("Schedule")
                        .HasForeignKey("TypeOfTransportId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UrbanTraffic.Stopping", b =>
                {
                    b.HasOne("UrbanTraffic.TypeOfTransport", "TypeOfTransport")
                        .WithMany("Stopping")
                        .HasForeignKey("TypeOfTransportId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UrbanTraffic.TransportService", b =>
                {
                    b.HasOne("UrbanTraffic.Employees", "Employees")
                        .WithMany("TransportService")
                        .HasForeignKey("EmployeesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanTraffic.Routes", "Routes")
                        .WithMany("TransportService")
                        .HasForeignKey("RoutesId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UrbanTraffic.TypeOfTransport", "TypeOfTransport")
                        .WithMany("TransportService")
                        .HasForeignKey("TypeOfTransportId");
                });
#pragma warning restore 612, 618
        }
    }
}
