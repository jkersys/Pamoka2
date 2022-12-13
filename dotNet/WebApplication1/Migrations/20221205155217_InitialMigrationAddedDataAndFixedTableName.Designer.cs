﻿// <auto-generated />
using ApiMokymai.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiMokymai.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20221205155217_InitialMigrationAddedDataAndFixedTableName")]
    partial class InitialMigrationAddedDataAndFixedTableName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("ApiMokymai.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CoverType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublishYear")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Tolkin",
                            CoverType = 0,
                            PublishYear = 1991,
                            Title = "Hobbit"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Leo Tolstoy",
                            CoverType = 0,
                            PublishYear = 1992,
                            Title = "War and peace"
                        },
                        new
                        {
                            Id = 3,
                            Author = "William Shakespeare",
                            CoverType = 1,
                            PublishYear = 1993,
                            Title = "Hamlet"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Homer",
                            CoverType = 2,
                            PublishYear = 1994,
                            Title = "The Odyssey"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Fyodor Dostoyevsky",
                            CoverType = 0,
                            PublishYear = 1995,
                            Title = " Crime and Punishment"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Tolkin",
                            CoverType = 0,
                            PublishYear = 1991,
                            Title = "Hobbit"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Leo Tolstoy",
                            CoverType = 0,
                            PublishYear = 1992,
                            Title = "War and peace"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Joseph Conrad",
                            CoverType = 1,
                            PublishYear = 1998,
                            Title = " Heart of Darkness"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Great Expectations",
                            CoverType = 2,
                            PublishYear = 1999,
                            Title = "Great Expectations"
                        },
                        new
                        {
                            Id = 10,
                            Author = "Tolkin",
                            CoverType = 0,
                            PublishYear = 1991,
                            Title = "Hobbit"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
