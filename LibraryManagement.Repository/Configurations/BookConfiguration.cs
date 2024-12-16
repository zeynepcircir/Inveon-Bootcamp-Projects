using LibraryManagement.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Repository.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.Title).IsRequired().HasMaxLength(200);
            builder.Property(b => b.Author).IsRequired().HasMaxLength(100);
            builder.Property(b => b.ISBN).IsRequired().HasMaxLength(20);
            builder.Property(b => b.Genre).IsRequired().HasMaxLength(50);
            builder.Property(b => b.Publisher).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Language).IsRequired().HasMaxLength(50);

            builder.Property(b => b.Summary).HasMaxLength(1000);
            builder.Property(b => b.AvailableCopies).IsRequired();
        }
    }
}
