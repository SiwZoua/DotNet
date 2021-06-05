using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;


namespace BookStore.Infrastructure.Context
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
