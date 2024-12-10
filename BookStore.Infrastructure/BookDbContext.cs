using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Infrastructure
{
    public class BookDbContext : DbContext
    {
        public DbSet<BookModel> Books { get; set; }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }
    }


}

