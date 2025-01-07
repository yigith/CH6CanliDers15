﻿// <auto-generated />
using MarketApp.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarketApp.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250107172218_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarketApp.DAL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "İçecekler"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Baharatlar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Tatlılar"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Süt Ürünleri"
                        });
                });

            modelBuilder.Entity("MarketApp.DAL.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Çay",
                            Price = 15.00m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Kahve",
                            Price = 18.50m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "Portakal Suyu",
                            Price = 12.00m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Name = "Şeftali Nektarı",
                            Price = 14.00m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Name = "Maden Suyu",
                            Price = 8.50m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Name = "Limonata",
                            Price = 11.00m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Name = "Pul Biber",
                            Price = 5.00m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Name = "Kekik",
                            Price = 3.00m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Name = "Karabiber",
                            Price = 6.50m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Name = "Kimyon",
                            Price = 4.75m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Name = "Nane",
                            Price = 2.85m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Name = "Sumak",
                            Price = 3.50m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 3,
                            Name = "Baklava",
                            Price = 25.00m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 3,
                            Name = "Lokum",
                            Price = 15.00m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 3,
                            Name = "Revani",
                            Price = 12.00m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 3,
                            Name = "Kazandibi",
                            Price = 10.00m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 3,
                            Name = "Şekerpare",
                            Price = 11.50m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 3,
                            Name = "Künefe",
                            Price = 20.00m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Name = "Beyaz Peynir",
                            Price = 35.00m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Name = "Kaşar Peynir",
                            Price = 45.00m
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Name = "Tereyağı",
                            Price = 40.00m
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Name = "Yoğurt",
                            Price = 12.00m
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Name = "Ayran",
                            Price = 5.00m
                        },
                        new
                        {
                            Id = 24,
                            CategoryId = 4,
                            Name = "Labne",
                            Price = 16.00m
                        });
                });

            modelBuilder.Entity("MarketApp.DAL.Entities.Product", b =>
                {
                    b.HasOne("MarketApp.DAL.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
