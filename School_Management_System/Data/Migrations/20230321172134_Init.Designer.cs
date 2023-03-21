﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using School_Management_System.Data;

namespace School_Management_System.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230321172134_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("School_Management_System.Data.Auth.ApplicationRole", b =>
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

            modelBuilder.Entity("School_Management_System.Data.Auth.ApplicationUser", b =>
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

                    b.Property<decimal?>("MaxAmount");

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

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(120);

                    b.Property<int?>("isActive");

                    b.Property<string>("org")
                        .HasMaxLength(120);

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(120);

                    b.Property<string>("userCode")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("userId");

                    b.Property<int?>("userTypeId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.HasIndex("userTypeId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("School_Management_System.Data.Auth.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("isDelete");

                    b.Property<int?>("shortOrder");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.Property<string>("userTypeName")
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("userTypeNameBn")
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("School_Management_System.Data.Entity.ClassInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameBn");

                    b.Property<string>("NameEn");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("isDelete");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("classInfos");
                });

            modelBuilder.Entity("School_Management_System.Data.Entity.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameBN");

                    b.Property<string>("NameEN");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("isDelete");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("genders");
                });

            modelBuilder.Entity("School_Management_System.Data.Entity.Resultsheet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Grade");

                    b.Property<string>("Subject");

                    b.Property<int>("TotalMarks");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("isDelete");

                    b.Property<int?>("studentInfoId");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("studentInfoId");

                    b.ToTable("resultsheets");
                });

            modelBuilder.Entity("School_Management_System.Data.Entity.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameBN");

                    b.Property<string>("NameEN");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("isDelete");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("sections");
                });

            modelBuilder.Entity("School_Management_System.Data.Entity.StudentInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Name");

                    b.Property<string>("Roll");

                    b.Property<int?>("classInfoId");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("genderId");

                    b.Property<int?>("isActive");

                    b.Property<int?>("isDelete");

                    b.Property<int?>("sectionId");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.Property<string>("url");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("classInfoId");

                    b.HasIndex("genderId");

                    b.HasIndex("sectionId");

                    b.ToTable("studentInfos");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.BookName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookNameBn")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("BookNameEn")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<int?>("Order");

                    b.Property<int?>("classId");

                    b.Property<int?>("classInfoId");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("isDelete");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.Property<string>("url");

                    b.HasKey("Id");

                    b.HasIndex("classInfoId");

                    b.ToTable("bookNames");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("countryCode")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("countryName")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("countryNameBn")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<string>("isActive")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<int?>("isDelete");

                    b.Property<string>("latitude")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("longitude")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("shortName")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<string>("districtCode")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("districtName")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("districtNameBn")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<int>("divisionId");

                    b.Property<string>("isActive")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<int?>("isDelete");

                    b.Property<string>("latitude")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("longitude")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("shortName")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("divisionId");

                    b.ToTable("districts");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("countryId");

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<string>("divisionCode")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("divisionName")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("divisionNameBn");

                    b.Property<string>("isActive")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<int?>("isDelete");

                    b.Property<string>("latitude")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("longitude")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("shortName")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("countryId");

                    b.ToTable("divisions");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.Occupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("isDelete");

                    b.Property<string>("occupationName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(180)");

                    b.Property<string>("occupationShortName")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<int?>("shortOrder");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("occupations");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.Religion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("isDelete");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(150)");

                    b.Property<string>("shortName")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("religions");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.Thana", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("createdAt");

                    b.Property<string>("createdBy")
                        .HasMaxLength(250);

                    b.Property<int?>("districtId");

                    b.Property<string>("isActive")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<int?>("isDelete");

                    b.Property<string>("latitude")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("longitude")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("shortName")
                        .HasColumnType("NVARCHAR(50)");

                    b.Property<string>("thanaCode")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("thanaName")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<string>("thanaNameBn")
                        .HasColumnType("NVARCHAR(120)");

                    b.Property<DateTime?>("updatedAt");

                    b.Property<string>("updatedBy")
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("districtId");

                    b.ToTable("thanas");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("School_Management_System.Data.Auth.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("School_Management_System.Data.Auth.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("School_Management_System.Data.Auth.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("School_Management_System.Data.Auth.ApplicationRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("School_Management_System.Data.Auth.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("School_Management_System.Data.Auth.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School_Management_System.Data.Auth.ApplicationUser", b =>
                {
                    b.HasOne("School_Management_System.Data.Auth.UserType", "userType")
                        .WithMany()
                        .HasForeignKey("userTypeId");
                });

            modelBuilder.Entity("School_Management_System.Data.Entity.Resultsheet", b =>
                {
                    b.HasOne("School_Management_System.Data.Entity.StudentInfo", "studentInfo")
                        .WithMany()
                        .HasForeignKey("studentInfoId");
                });

            modelBuilder.Entity("School_Management_System.Data.Entity.StudentInfo", b =>
                {
                    b.HasOne("School_Management_System.Data.Auth.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("School_Management_System.Data.Entity.ClassInfo", "classInfo")
                        .WithMany()
                        .HasForeignKey("classInfoId");

                    b.HasOne("School_Management_System.Data.Entity.Gender", "gender")
                        .WithMany()
                        .HasForeignKey("genderId");

                    b.HasOne("School_Management_System.Data.Entity.Section", "section")
                        .WithMany()
                        .HasForeignKey("sectionId");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.BookName", b =>
                {
                    b.HasOne("School_Management_System.Data.Entity.ClassInfo", "classInfo")
                        .WithMany()
                        .HasForeignKey("classInfoId");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.District", b =>
                {
                    b.HasOne("School_Management_System.Data.MasterData.Division", "division")
                        .WithMany()
                        .HasForeignKey("divisionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.Division", b =>
                {
                    b.HasOne("School_Management_System.Data.MasterData.Country", "country")
                        .WithMany()
                        .HasForeignKey("countryId");
                });

            modelBuilder.Entity("School_Management_System.Data.MasterData.Thana", b =>
                {
                    b.HasOne("School_Management_System.Data.MasterData.District", "district")
                        .WithMany()
                        .HasForeignKey("districtId");
                });
#pragma warning restore 612, 618
        }
    }
}
