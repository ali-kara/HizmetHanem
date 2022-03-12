﻿// <auto-generated />
using System;
using DataAccessLayer.Concrete.EF.MainDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccessLayer.Migrations
{
    [DbContext(typeof(MainDBContext))]
    [Migration("20220310095342_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUser")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Yiyecekler",
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 440, DateTimeKind.Local).AddTicks(6220),
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "İçecekler",
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6967),
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Sütlü Tatlılar",
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6985),
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Soğuk Tatlılar",
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6988),
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Meyveler",
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6990),
                            IsDeleted = false
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Ara Sıcaklar",
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 441, DateTimeKind.Local).AddTicks(6991),
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 442, DateTimeKind.Local).AddTicks(8236),
                            IsDeleted = false,
                            Name = "Peters PLC"
                        },
                        new
                        {
                            CompanyId = 2,
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 443, DateTimeKind.Local).AddTicks(8521),
                            IsDeleted = false,
                            Name = "Haines Group"
                        },
                        new
                        {
                            CompanyId = 3,
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 443, DateTimeKind.Local).AddTicks(8546),
                            IsDeleted = false,
                            Name = "Whitehouse and Partners"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Menu", b =>
                {
                    b.Property<int>("MenuId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            MenuId = 1,
                            CompanyId = 1,
                            Name = "Menu 1"
                        },
                        new
                        {
                            MenuId = 2,
                            CompanyId = 2,
                            Name = "Menu 2"
                        });
                });

            modelBuilder.Entity("Entities.Concrete.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastUser")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MenuId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("MenuItemId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("MenuId");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            MenuItemId = 1,
                            CategoryId = 1,
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 444, DateTimeKind.Local).AddTicks(786),
                            Description = "Sed adipiscing dolor eget turpis eleifend eleifend. Nullam et enim congue, pretium eros id, pretium nibh. Nullam et enim congue, pretium eros id, pretium nibh.",
                            IsDeleted = false,
                            ItemName = "Whitehouse",
                            MenuId = 1,
                            Price = 40.0
                        },
                        new
                        {
                            MenuItemId = 2,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 445, DateTimeKind.Local).AddTicks(8449),
                            Description = "Duis gravida erat et euismod consequat. In laoreet justo et condimentum bibendum. Phasellus pharetra leo eu tempor molestie.",
                            IsDeleted = false,
                            ItemName = "Fleming",
                            MenuId = 2,
                            Price = 23.399999999999999
                        },
                        new
                        {
                            MenuItemId = 3,
                            CategoryId = 3,
                            DateCreated = new DateTime(2022, 3, 10, 12, 53, 42, 445, DateTimeKind.Local).AddTicks(8632),
                            Description = "Vivamus porta neque non neque malesuada scelerisque. Vivamus scelerisque felis sed nisl feugiat, mattis consequat lacus pulvinar. Nullam quis turpis eu urna vehicula ornare vel et enim.",
                            IsDeleted = false,
                            ItemName = "Hilton",
                            MenuId = 2,
                            Price = 54.0
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Menu", b =>
                {
                    b.HasOne("Entities.Concrete.Company", "Company")
                        .WithMany("Menus")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Entities.Concrete.MenuItem", b =>
                {
                    b.HasOne("Entities.Concrete.Category", "Category")
                        .WithMany("MenuItems")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Menu");
                });

            modelBuilder.Entity("Entities.Concrete.Category", b =>
                {
                    b.Navigation("MenuItems");
                });

            modelBuilder.Entity("Entities.Concrete.Company", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
