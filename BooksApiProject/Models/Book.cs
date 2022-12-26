

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BooksApiProject.Models
{ 
    public class Book
    {
        public Book(int id, string title, decimal price, string genre, DateTime publishDate, string description, Author author)
        {
            Id = id;
            Title = title;
            Price = price;
            Genre = genre;
            PublishDate = publishDate;
            Description = description;
            Author = author;
        }



        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public DateTime PublishDate { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
    }
}