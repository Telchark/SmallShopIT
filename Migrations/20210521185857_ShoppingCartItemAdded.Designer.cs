﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmallShopIT.Models;

namespace SmallShopIT.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210521185857_ShoppingCartItemAdded")]
    partial class ShoppingCartItemAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SmallShopIT.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Software"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Printers"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Personal Computers"
                        });
                });

            modelBuilder.Entity("SmallShopIT.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Recommended")
                        .HasColumnType("bit");

                    b.Property<string>("ShortDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 3,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/desktop_pc.jpg",
                            InStock = true,
                            Name = "Komputer",
                            Price = 2999.99m,
                            Recommended = false,
                            ShortDesc = "Komputer krótki opis."
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 3,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/laptop.jpg",
                            InStock = true,
                            Name = "Laptop",
                            Price = 999.99m,
                            Recommended = false,
                            ShortDesc = "Laptop krótki opis."
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/printer.jpg",
                            InStock = true,
                            Name = "Drukarka",
                            Price = 400.00m,
                            Recommended = false,
                            ShortDesc = "Drukarka krótki opis."
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/software.jpg",
                            InStock = true,
                            Name = "Software",
                            Price = 900.00m,
                            Recommended = false,
                            ShortDesc = "Software krótki opis."
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/software2.jpg",
                            InStock = true,
                            Name = "Software2",
                            Price = 9000.00m,
                            Recommended = false,
                            ShortDesc = "Software2 krótki opis."
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 3,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/super_pc.jpg",
                            InStock = true,
                            Name = "Super komputer",
                            Price = 12000.00m,
                            Recommended = false,
                            ShortDesc = "Super komputer krótki opis."
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/super_laptop.jpg",
                            InStock = true,
                            Name = "Super Laptop",
                            Price = 7000.00m,
                            Recommended = false,
                            ShortDesc = "Super Laptop krótki opis."
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 2,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/super_printer.jpg",
                            InStock = true,
                            Name = "Super Drukarka",
                            Price = 5000.00m,
                            Recommended = false,
                            ShortDesc = "Super Drukarka krótki opis."
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/software3.jpg",
                            InStock = true,
                            Name = "Software3",
                            Price = 900.00m,
                            Recommended = false,
                            ShortDesc = "Software3 krótki opis."
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 1,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/long_pc.jpg",
                            InStock = true,
                            Name = "Komputer o długiej nazwie",
                            Price = 1500.00m,
                            Recommended = false,
                            ShortDesc = "Komputer o długiej nazwie krótki opis."
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 2,
                            Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English.",
                            Image = "/Images/long_printer.jpg",
                            InStock = true,
                            Name = "Drukarka o jeszcze dłuższej nazwie",
                            Price = 244.00m,
                            Recommended = false,
                            ShortDesc = "Drukarka o jeszcze dłuższej nazwie krótki opis."
                        });
                });

            modelBuilder.Entity("SmallShopIT.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("SmallShopIT.Models.Product", b =>
                {
                    b.HasOne("SmallShopIT.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SmallShopIT.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("SmallShopIT.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SmallShopIT.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
