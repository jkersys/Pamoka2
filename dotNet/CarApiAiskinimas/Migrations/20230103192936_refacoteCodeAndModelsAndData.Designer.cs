﻿// <auto-generated />
using System;
using CarApiAiskinimas.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarApiAiskinimas.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20230103192936_refacoteCodeAndModelsAndData")]
    partial class refacoteCodeAndModelsAndData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("CarApiAiskinimas.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fuel")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("GearBox")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("TEXT");

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("PlateNumber")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Year")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Fuel = "Petrol",
                            GearBox = "Manual",
                            Mark = "VW",
                            Model = "Golf",
                            PlateNumber = "AAA 001",
                            Year = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Fuel = "Electric",
                            GearBox = "Automatic",
                            Mark = "Toyota",
                            Model = "Prius",
                            PlateNumber = "AAB 001",
                            Year = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Fuel = "Diesel",
                            GearBox = "Manual",
                            Mark = "Opel",
                            Model = "Astra",
                            PlateNumber = "AAC 001",
                            Year = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Fuel = "Diesel",
                            GearBox = "Manual",
                            Mark = "VW",
                            Model = "Passat",
                            PlateNumber = "AAA 002",
                            Year = new DateTime(2018, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("CarApiAiskinimas.Models.CarUser", b =>
                {
                    b.Property<int>("CarId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LocalUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarId", "LocalUserId");

                    b.ToTable("CarUser");
                });

            modelBuilder.Entity("CarApiAiskinimas.Models.LocalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
