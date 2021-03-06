﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Selling_Phone.Models;

namespace Selling_Phone.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200629025325_SeedingProductData")]
    partial class SeedingProductData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Selling_Phone.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvatarPatch")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Manufactory")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            AvatarPatch = "images/iphone-11-pro-max.png",
                            Manufactory = 0,
                            Name = "Apple iPhone 11 Pro Max-512GB",
                            Price = "36.790.000 đ"
                        },
                        new
                        {
                            ProductId = 2,
                            AvatarPatch = "images/iphone-11-pro.png",
                            Manufactory = 0,
                            Name = "Apple iPhone 11 Pro-256GB",
                            Price = "30.490.000 đ"
                        },
                        new
                        {
                            ProductId = 3,
                            AvatarPatch = "images/note-10-p.png",
                            Manufactory = 0,
                            Name = "Samsung Galaxy Note 10 Plus",
                            Price = "23.890.000 đ"
                        },
                        new
                        {
                            ProductId = 4,
                            AvatarPatch = "images/s20Ultra.png",
                            Manufactory = 0,
                            Name = "Samsung Galaxy S20 Ultra ",
                            Price = "20.950.000 đ"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
