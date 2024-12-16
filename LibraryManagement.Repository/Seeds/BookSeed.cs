using LibraryManagement.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Seeds
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    PublicationYear = 1960,
                    ISBN = "9780061120084",
                    Genre = "Fiction",
                    Publisher = "J.B. Lippincott & Co.",
                    PageCount = 281,
                    Language = "English",
                    Summary = "A novel about the serious issues of rape and racial inequality.",
                    AvailableCopies = 5
                },
                new Book
                {
                    Id = 2,
                    Title = "1984",
                    Author = "George Orwell",
                    PublicationYear = 1949,
                    ISBN = "9780451524935",
                    Genre = "Dystopian",
                    Publisher = "Secker & Warburg",
                    PageCount = 328,
                    Language = "English",
                    Summary = "A story about a dystopian future under a totalitarian regime.",
                    AvailableCopies = 3
                },
                new Book
                {
                    Id = 3,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    PublicationYear = 1813,
                    ISBN = "9780141040349",
                    Genre = "Romance",
                    Publisher = "T. Egerton",
                    PageCount = 432,
                    Language = "English",
                    Summary = "A classic novel about love and social standing in 19th-century England.",
                    AvailableCopies = 4
                },
                new Book
                {
                    Id = 4,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    PublicationYear = 1925,
                    ISBN = "9780743273565",
                    Genre = "Tragedy",
                    Publisher = "Charles Scribner's Sons",
                    PageCount = 180,
                    Language = "English",
                    Summary = "A critique of the American Dream in the Jazz Age.",
                    AvailableCopies = 2
                },
                new Book
                {
                    Id = 5,
                    Title = "Moby Dick",
                    Author = "Herman Melville",
                    PublicationYear = 1851,
                    ISBN = "9781503280786",
                    Genre = "Adventure",
                    Publisher = "Richard Bentley",
                    PageCount = 635,
                    Language = "English",
                    Summary = "A tale of obsession and revenge on the high seas.",
                    AvailableCopies = 6
                }
            );
        }
    }
}
