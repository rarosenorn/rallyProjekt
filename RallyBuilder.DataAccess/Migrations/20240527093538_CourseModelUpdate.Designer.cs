﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RallyBuilder.DataAccess;

#nullable disable

namespace RallyBuilder.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDatabaseContext))]
    [Migration("20240527093538_CourseModelUpdate")]
    partial class CourseModelUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "ed24eb0e-a8f0-4e3a-93b7-909df4954b82",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        },
                        new
                        {
                            Id = "75bbc373-d29a-4ed6-b322-de46f4312551",
                            Name = "Dommer",
                            NormalizedName = "DOMMER"
                        },
                        new
                        {
                            Id = "f86b9f3f-929c-4030-bd2f-dce4ce5c8351",
                            Name = "Instruktør",
                            NormalizedName = "INSTRUKTØR"
                        },
                        new
                        {
                            Id = "02dd646c-f4f9-480a-b125-ffbf44312e3d",
                            Name = "Hundefører",
                            NormalizedName = "HUNDEFØRER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("varchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "6f3db85d-7e42-443e-b90a-356452f9b2ea",
                            RoleId = "ed24eb0e-a8f0-4e3a-93b7-909df4954b82"
                        },
                        new
                        {
                            UserId = "3651b661-441e-4afa-b38a-42085002c141",
                            RoleId = "75bbc373-d29a-4ed6-b322-de46f4312551"
                        },
                        new
                        {
                            UserId = "6eb46dfe-6dfb-42bf-afbc-39fa23173a05",
                            RoleId = "f86b9f3f-929c-4030-bd2f-dce4ce5c8351"
                        },
                        new
                        {
                            UserId = "c46e8c25-1a36-4a9f-b472-7c7733d15f7c",
                            RoleId = "02dd646c-f4f9-480a-b125-ffbf44312e3d"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RallyBuilder.Models.CourseModel", b =>
                {
                    b.Property<int>("CourseModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CourseModelId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CreatedByUserId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("CourseModelId");

                    b.ToTable("CourseModels");
                });

            modelBuilder.Entity("RallyBuilder.Models.CourseSignEntry", b =>
                {
                    b.Property<int>("CourseSignEntryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CourseSignEntryId"));

                    b.Property<int>("CourseModelId")
                        .HasColumnType("int");

                    b.Property<int>("SignModelId")
                        .HasColumnType("int");

                    b.Property<int?>("SignNumberOnCourse")
                        .HasColumnType("int");

                    b.Property<int>("SquareNumber")
                        .HasColumnType("int");

                    b.HasKey("CourseSignEntryId");

                    b.HasIndex("CourseModelId");

                    b.HasIndex("SignModelId");

                    b.ToTable("CourseSignEntries");
                });

            modelBuilder.Entity("RallyBuilder.Models.SignModel", b =>
                {
                    b.Property<int>("SignModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("SignModelId"));

                    b.Property<string>("IconPath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int?>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("SignModelId");

                    b.ToTable("SignModels");
                });

            modelBuilder.Entity("RallyBuilder.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Location")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "6f3db85d-7e42-443e-b90a-356452f9b2ea",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8dcd42fd-8f6c-4b93-924a-79c271b2831c",
                            Email = "administrator@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINISTRATOR@TEST.COM",
                            NormalizedUserName = "ADMINISTRATOR@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKv8AbHhT/AycQDWE1QDfaAxoi7396Jm0TwfO2g8RlnWJIfrDm7CSVwDjzp3wSZKTQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ab66ae5b-f2c4-4db8-a10b-1b0761bb856b",
                            TwoFactorEnabled = false,
                            UserName = "administrator@test.com"
                        },
                        new
                        {
                            Id = "3651b661-441e-4afa-b38a-42085002c141",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b00e076e-cf18-4adf-aaee-a05857057f54",
                            Email = "dommer@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "DOMMER@TEST.COM",
                            NormalizedUserName = "DOMMER@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEA21cQcIj/WrKK+biT8g4Ii+KuAJ9XYk5mJ8JytTm0QAjW6tiA5bkmjuzl7pPw6J1g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bf31e48c-863c-48fc-b18b-3729c3941e8e",
                            TwoFactorEnabled = false,
                            UserName = "dommer@test.com"
                        },
                        new
                        {
                            Id = "6eb46dfe-6dfb-42bf-afbc-39fa23173a05",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "03b5d9ef-fb7a-492e-9250-85acde44d385",
                            Email = "instruktør@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "INSTRUKTØR@TEST.COM",
                            NormalizedUserName = "INSTRUKTØR@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEGe9xJjeV605UIJCP2uVMc8UxXNrUx2aIm6b++Q5u/CuWIBYxNBnroNXeugOKBgI0A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "dd1eb87c-522e-442d-bf95-007b98d90010",
                            TwoFactorEnabled = false,
                            UserName = "instruktør@test.com"
                        },
                        new
                        {
                            Id = "c46e8c25-1a36-4a9f-b472-7c7733d15f7c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "47890515-47ef-4ac9-bee9-595f6fc9a688",
                            Email = "hundefører@test.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "HUNDEFØRER@TEST.COM",
                            NormalizedUserName = "HUNDEFØRER@TEST.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEEd2bvS4GvPjD7W+SotRtxBf9Kv2DUwlWZJMmUBPwjp/c1YUNu7qQkbPSWQkS3+wuA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9850b553-f6e4-4057-8089-084573f92f17",
                            TwoFactorEnabled = false,
                            UserName = "hundefører@test.com"
                        });
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RallyBuilder.Models.CourseSignEntry", b =>
                {
                    b.HasOne("RallyBuilder.Models.CourseModel", null)
                        .WithMany("CourseSignEntries")
                        .HasForeignKey("CourseModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RallyBuilder.Models.SignModel", "SignModel")
                        .WithMany()
                        .HasForeignKey("SignModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SignModel");
                });

            modelBuilder.Entity("RallyBuilder.Models.CourseModel", b =>
                {
                    b.Navigation("CourseSignEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
