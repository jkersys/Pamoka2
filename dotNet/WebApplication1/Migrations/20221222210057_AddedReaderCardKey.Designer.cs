﻿// <auto-generated />
using System;
using ApiMokymai.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiMokymai.Migrations
{
    [DbContext(typeof(BookContext))]
    [Migration("20221222210057_AddedReaderCardKey")]
    partial class AddedReaderCardKey
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true);

            modelBuilder.Entity("ApiMokymai.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ECoverType")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PublishYear")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdateDateTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Tolkin",
                            ECoverType = 0,
                            PublishYear = 2012,
                            Quantity = 6,
                            Title = "Hobbit",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Author = "Leo Tolstoy",
                            ECoverType = 0,
                            PublishYear = 1992,
                            Quantity = 7,
                            Title = "War and peace",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Author = "William Shakespeare",
                            ECoverType = 1,
                            PublishYear = 2005,
                            Quantity = 6,
                            Title = "Hamlet",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Author = "Homer",
                            ECoverType = 2,
                            PublishYear = 1994,
                            Quantity = 2,
                            Title = "The Odyssey",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Author = "Fyodor Dostoyevsky",
                            ECoverType = 0,
                            PublishYear = 1995,
                            Quantity = 7,
                            Title = " Crime and Punishment",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            Author = "Tolkin",
                            ECoverType = 0,
                            PublishYear = 1991,
                            Quantity = 12,
                            Title = "Hobbit",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            Author = "Leo Tolstoy",
                            ECoverType = 0,
                            PublishYear = 2018,
                            Quantity = 1,
                            Title = "War and peace",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            Author = "Joseph Conrad",
                            ECoverType = 1,
                            PublishYear = 1998,
                            Quantity = 5,
                            Title = " Heart of Darkness",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            Author = "Great Expectations",
                            ECoverType = 2,
                            PublishYear = 1999,
                            Quantity = 8,
                            Title = "Great Expectations",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            Author = "Tolkin",
                            ECoverType = 0,
                            PublishYear = 2000,
                            Quantity = 2,
                            Title = "Hobbit",
                            UpdateDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ApiMokymai.Models.ReaderCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BooksLateToReturnAtm")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BooksLoeanedAtm")
                        .HasColumnType("INTEGER");

                    b.Property<double?>("Debt")
                        .HasColumnType("REAL");

                    b.Property<int?>("UserBooksId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("ReaderCard");
                });

            modelBuilder.Entity("ApiMokymai.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("BLOB");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ApiMokymai.Models.UserBooks", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BookId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("BorrowDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("ReaderCardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Returned")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.ToTable("UserBooks");
                });

            modelBuilder.Entity("ApiMokymai.Models.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserRole");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Secretary"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Customer"
                        });
                });

            modelBuilder.Entity("ReaderCardUserBooks", b =>
                {
                    b.Property<int>("ReaderCardId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserBooksId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ReaderCardId", "UserBooksId");

                    b.HasIndex("UserBooksId");

                    b.ToTable("ReaderCardUserBooks");
                });

            modelBuilder.Entity("ApiMokymai.Models.ReaderCard", b =>
                {
                    b.HasOne("ApiMokymai.Models.User", "User")
                        .WithOne("UserReaderCard")
                        .HasForeignKey("ApiMokymai.Models.ReaderCard", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ApiMokymai.Models.User", b =>
                {
                    b.HasOne("ApiMokymai.Models.UserRole", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ApiMokymai.Models.UserBooks", b =>
                {
                    b.HasOne("ApiMokymai.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("ReaderCardUserBooks", b =>
                {
                    b.HasOne("ApiMokymai.Models.ReaderCard", null)
                        .WithMany()
                        .HasForeignKey("ReaderCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ApiMokymai.Models.UserBooks", null)
                        .WithMany()
                        .HasForeignKey("UserBooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ApiMokymai.Models.User", b =>
                {
                    b.Navigation("UserReaderCard")
                        .IsRequired();
                });

            modelBuilder.Entity("ApiMokymai.Models.UserRole", b =>
                {
                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
