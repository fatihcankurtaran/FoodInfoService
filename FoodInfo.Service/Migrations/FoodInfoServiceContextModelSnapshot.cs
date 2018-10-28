﻿// <auto-generated />
using System;
using FoodInfo.Service.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodInfo.Service.Migrations
{
    [DbContext(typeof(FoodInfoServiceContext))]
    partial class FoodInfoServiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodInfo.Service.Models.Language", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryCode");

                    b.Property<string>("CountryName");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int?>("ModifiedUserId");

                    b.HasKey("ID");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("FoodInfo.Service.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BarkodId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int?>("ModifiedUserId");

                    b.Property<int?>("ProductCategoryID");

                    b.Property<int>("ProductGroupId");

                    b.Property<string>("ProductName");

                    b.Property<string>("ProductPicturePath");

                    b.HasKey("ID");

                    b.HasIndex("ProductCategoryID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FoodInfo.Service.Models.ProductCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int?>("ModifiedUserId");

                    b.HasKey("ID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("FoodInfo.Service.Models.ProductLanguage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<bool>("IsDeleted");

                    b.Property<int?>("LanguageID");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int?>("ModifiedUserId");

                    b.Property<int?>("ProductID");

                    b.HasKey("ID");

                    b.HasIndex("LanguageID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductLanguages");
                });

            modelBuilder.Entity("FoodInfo.Service.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CreatedUserId");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int?>("ModifiedUserId");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Surname");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("User");

                    b.HasData(
                        new { ID = 1, CreatedDate = new DateTime(2018, 10, 26, 19, 59, 27, 856, DateTimeKind.Local), IsDeleted = false, Name = "Fatih", Surname = "Cankurtaran" },
                        new { ID = 2, CreatedDate = new DateTime(2018, 10, 26, 19, 59, 27, 858, DateTimeKind.Local), IsDeleted = false, Name = "Yusuf", Surname = "Kocadas" }
                    );
                });

            modelBuilder.Entity("FoodInfo.Service.Models.Product", b =>
                {
                    b.HasOne("FoodInfo.Service.Models.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryID");
                });

            modelBuilder.Entity("FoodInfo.Service.Models.ProductLanguage", b =>
                {
                    b.HasOne("FoodInfo.Service.Models.Language", "Language")
                        .WithMany("ProductLanguages")
                        .HasForeignKey("LanguageID");

                    b.HasOne("FoodInfo.Service.Models.Product", "Product")
                        .WithMany("ProductLanguages")
                        .HasForeignKey("ProductID");
                });
#pragma warning restore 612, 618
        }
    }
}