﻿// <auto-generated />
using System;
using LibraryManagement.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManagement.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryManagement.Core.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("AvailableCopies")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PageCount")
                        .HasColumnType("int");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("int");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Summary")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Harper Lee",
                            AvailableCopies = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Fiction",
                            ISBN = "9780061120084",
                            Language = "English",
                            PageCount = 281,
                            PublicationYear = 1960,
                            Publisher = "J.B. Lippincott & Co.",
                            Summary = "A novel about the serious issues of rape and racial inequality.",
                            Title = "To Kill a Mockingbird"
                        },
                        new
                        {
                            Id = 2,
                            Author = "George Orwell",
                            AvailableCopies = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Dystopian",
                            ISBN = "9780451524935",
                            Language = "English",
                            PageCount = 328,
                            PublicationYear = 1949,
                            Publisher = "Secker & Warburg",
                            Summary = "A story about a dystopian future under a totalitarian regime.",
                            Title = "1984"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Jane Austen",
                            AvailableCopies = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Romance",
                            ISBN = "9780141040349",
                            Language = "English",
                            PageCount = 432,
                            PublicationYear = 1813,
                            Publisher = "T. Egerton",
                            Summary = "A classic novel about love and social standing in 19th-century England.",
                            Title = "Pride and Prejudice"
                        },
                        new
                        {
                            Id = 4,
                            Author = "F. Scott Fitzgerald",
                            AvailableCopies = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Tragedy",
                            ISBN = "9780743273565",
                            Language = "English",
                            PageCount = 180,
                            PublicationYear = 1925,
                            Publisher = "Charles Scribner's Sons",
                            Summary = "A critique of the American Dream in the Jazz Age.",
                            Title = "The Great Gatsby"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Herman Melville",
                            AvailableCopies = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Genre = "Adventure",
                            ISBN = "9781503280786",
                            Language = "English",
                            PageCount = 635,
                            PublicationYear = 1851,
                            Publisher = "Richard Bentley",
                            Summary = "A tale of obsession and revenge on the high seas.",
                            Title = "Moby Dick"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
