﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cafe.infrastructure;

#nullable disable

namespace cafe.Migrations
{
    [DbContext(typeof(CafeDbContext))]
    [Migration("20240319201546_CreateClientTable")]
    partial class CreateClientTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("cafe.Domain.Category.CategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Catgeories");
                });

            modelBuilder.Entity("cafe.Domain.Client.Entity.ClientEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsVIP")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Preference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("cafe.Domain.Employee.EmployeeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BaseSalary")
                        .HasColumnType("int");

                    b.Property<string>("DeliverdPapers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("cafe.Domain.Employee.SalaryItemEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Reason")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SalaryItemEntity");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SalaryItemEntity");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("cafe.Domain.Meal.MealEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryEntityId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryEntityId");

                    b.ToTable("Meals");
                });

            modelBuilder.Entity("cafe.Domain.Table.Entity.TableEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClientId")
                        .HasColumnType("int");

                    b.Property<int>("LobbyName")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LobbyName = 0,
                            Name = "1"
                        },
                        new
                        {
                            Id = 2,
                            LobbyName = 0,
                            Name = "2"
                        },
                        new
                        {
                            Id = 3,
                            LobbyName = 0,
                            Name = "3"
                        },
                        new
                        {
                            Id = 4,
                            LobbyName = 0,
                            Name = "4"
                        },
                        new
                        {
                            Id = 5,
                            LobbyName = 0,
                            Name = "5"
                        },
                        new
                        {
                            Id = 6,
                            LobbyName = 0,
                            Name = "6"
                        },
                        new
                        {
                            Id = 7,
                            LobbyName = 0,
                            Name = "7"
                        },
                        new
                        {
                            Id = 8,
                            LobbyName = 0,
                            Name = "8"
                        },
                        new
                        {
                            Id = 9,
                            LobbyName = 0,
                            Name = "9"
                        },
                        new
                        {
                            Id = 10,
                            LobbyName = 0,
                            Name = "10"
                        },
                        new
                        {
                            Id = 11,
                            LobbyName = 0,
                            Name = "11"
                        },
                        new
                        {
                            Id = 12,
                            LobbyName = 0,
                            Name = "12"
                        },
                        new
                        {
                            Id = 13,
                            LobbyName = 0,
                            Name = "13"
                        },
                        new
                        {
                            Id = 14,
                            LobbyName = 0,
                            Name = "14"
                        },
                        new
                        {
                            Id = 15,
                            LobbyName = 0,
                            Name = "15"
                        },
                        new
                        {
                            Id = 16,
                            LobbyName = 0,
                            Name = "16"
                        },
                        new
                        {
                            Id = 17,
                            LobbyName = 0,
                            Name = "17"
                        },
                        new
                        {
                            Id = 18,
                            LobbyName = 0,
                            Name = "18"
                        },
                        new
                        {
                            Id = 19,
                            LobbyName = 0,
                            Name = "19"
                        },
                        new
                        {
                            Id = 20,
                            LobbyName = 0,
                            Name = "20"
                        },
                        new
                        {
                            Id = 21,
                            LobbyName = 0,
                            Name = "21"
                        },
                        new
                        {
                            Id = 22,
                            LobbyName = 0,
                            Name = "22"
                        },
                        new
                        {
                            Id = 23,
                            LobbyName = 0,
                            Name = "23"
                        },
                        new
                        {
                            Id = 24,
                            LobbyName = 0,
                            Name = "24"
                        },
                        new
                        {
                            Id = 25,
                            LobbyName = 0,
                            Name = "25"
                        },
                        new
                        {
                            Id = 26,
                            LobbyName = 0,
                            Name = "26"
                        },
                        new
                        {
                            Id = 27,
                            LobbyName = 0,
                            Name = "27"
                        },
                        new
                        {
                            Id = 28,
                            LobbyName = 0,
                            Name = "28"
                        },
                        new
                        {
                            Id = 29,
                            LobbyName = 0,
                            Name = "29"
                        },
                        new
                        {
                            Id = 30,
                            LobbyName = 0,
                            Name = "30"
                        },
                        new
                        {
                            Id = 31,
                            LobbyName = 0,
                            Name = "31"
                        },
                        new
                        {
                            Id = 32,
                            LobbyName = 1,
                            Name = "32"
                        },
                        new
                        {
                            Id = 33,
                            LobbyName = 1,
                            Name = "33"
                        },
                        new
                        {
                            Id = 34,
                            LobbyName = 1,
                            Name = "34"
                        },
                        new
                        {
                            Id = 35,
                            LobbyName = 1,
                            Name = "35"
                        },
                        new
                        {
                            Id = 36,
                            LobbyName = 1,
                            Name = "36"
                        },
                        new
                        {
                            Id = 37,
                            LobbyName = 1,
                            Name = "37"
                        },
                        new
                        {
                            Id = 38,
                            LobbyName = 1,
                            Name = "38"
                        },
                        new
                        {
                            Id = 39,
                            LobbyName = 1,
                            Name = "39"
                        },
                        new
                        {
                            Id = 40,
                            LobbyName = 1,
                            Name = "40"
                        },
                        new
                        {
                            Id = 41,
                            LobbyName = 1,
                            Name = "41"
                        },
                        new
                        {
                            Id = 42,
                            LobbyName = 1,
                            Name = "42"
                        },
                        new
                        {
                            Id = 43,
                            LobbyName = 1,
                            Name = "43"
                        },
                        new
                        {
                            Id = 44,
                            LobbyName = 1,
                            Name = "44"
                        },
                        new
                        {
                            Id = 45,
                            LobbyName = 1,
                            Name = "45"
                        },
                        new
                        {
                            Id = 46,
                            LobbyName = 1,
                            Name = "46"
                        },
                        new
                        {
                            Id = 47,
                            LobbyName = 1,
                            Name = "47"
                        },
                        new
                        {
                            Id = 48,
                            LobbyName = 1,
                            Name = "48"
                        },
                        new
                        {
                            Id = 49,
                            LobbyName = 1,
                            Name = "49"
                        },
                        new
                        {
                            Id = 50,
                            LobbyName = 1,
                            Name = "50"
                        },
                        new
                        {
                            Id = 51,
                            LobbyName = 1,
                            Name = "51"
                        },
                        new
                        {
                            Id = 52,
                            LobbyName = 1,
                            Name = "52"
                        },
                        new
                        {
                            Id = 53,
                            LobbyName = 1,
                            Name = "53"
                        },
                        new
                        {
                            Id = 54,
                            LobbyName = 1,
                            Name = "54"
                        },
                        new
                        {
                            Id = 55,
                            LobbyName = 1,
                            Name = "55"
                        },
                        new
                        {
                            Id = 56,
                            LobbyName = 1,
                            Name = "56"
                        },
                        new
                        {
                            Id = 57,
                            LobbyName = 1,
                            Name = "57"
                        },
                        new
                        {
                            Id = 58,
                            LobbyName = 1,
                            Name = "58"
                        },
                        new
                        {
                            Id = 59,
                            LobbyName = 1,
                            Name = "59"
                        },
                        new
                        {
                            Id = 60,
                            LobbyName = 1,
                            Name = "60"
                        });
                });

            modelBuilder.Entity("cafe.Domain.Users.entity.CafeUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("cafe.Domain.Employee.SalaryDeductionEntity", b =>
                {
                    b.HasBaseType("cafe.Domain.Employee.SalaryItemEntity");

                    b.Property<int?>("EmployeeEntityId")
                        .HasColumnType("int");

                    b.HasIndex("EmployeeEntityId");

                    b.ToTable("SalaryItemEntity", t =>
                        {
                            t.Property("EmployeeEntityId")
                                .HasColumnName("SalaryDeductionEntity_EmployeeEntityId");
                        });

                    b.HasDiscriminator().HasValue("SalaryDeduction");
                });

            modelBuilder.Entity("cafe.Domain.Employee.SalaryIncentiveEntity", b =>
                {
                    b.HasBaseType("cafe.Domain.Employee.SalaryItemEntity");

                    b.Property<int?>("EmployeeEntityId")
                        .HasColumnType("int");

                    b.HasIndex("EmployeeEntityId");

                    b.HasDiscriminator().HasValue("SalaryIncentive");
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
                    b.HasOne("cafe.Domain.Users.entity.CafeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("cafe.Domain.Users.entity.CafeUser", null)
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

                    b.HasOne("cafe.Domain.Users.entity.CafeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("cafe.Domain.Users.entity.CafeUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("cafe.Domain.Meal.MealEntity", b =>
                {
                    b.HasOne("cafe.Domain.Category.CategoryEntity", null)
                        .WithMany("Meals")
                        .HasForeignKey("CategoryEntityId");
                });

            modelBuilder.Entity("cafe.Domain.Table.Entity.TableEntity", b =>
                {
                    b.HasOne("cafe.Domain.Client.Entity.ClientEntity", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("cafe.Domain.Employee.SalaryDeductionEntity", b =>
                {
                    b.HasOne("cafe.Domain.Employee.EmployeeEntity", null)
                        .WithMany("Deductions")
                        .HasForeignKey("EmployeeEntityId");
                });

            modelBuilder.Entity("cafe.Domain.Employee.SalaryIncentiveEntity", b =>
                {
                    b.HasOne("cafe.Domain.Employee.EmployeeEntity", null)
                        .WithMany("Incentive")
                        .HasForeignKey("EmployeeEntityId");
                });

            modelBuilder.Entity("cafe.Domain.Category.CategoryEntity", b =>
                {
                    b.Navigation("Meals");
                });

            modelBuilder.Entity("cafe.Domain.Employee.EmployeeEntity", b =>
                {
                    b.Navigation("Deductions");

                    b.Navigation("Incentive");
                });
#pragma warning restore 612, 618
        }
    }
}