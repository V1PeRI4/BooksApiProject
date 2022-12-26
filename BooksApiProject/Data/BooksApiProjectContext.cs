using System;
using Microsoft.EntityFrameworkCore;

namespace BooksApiProject.Models
{
    public class BooksApiProjectContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public BooksApiProjectContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("BooksApi"));
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}

