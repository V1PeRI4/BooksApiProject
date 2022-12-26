using System;
using Microsoft.EntityFrameworkCore;


namespace BooksApiProject.Models
{
    public class BookContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public BookContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString(""));
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}

