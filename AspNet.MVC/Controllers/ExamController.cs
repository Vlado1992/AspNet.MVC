using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            // autori
            var author1 = new Author { Id = 1, Name = "George R.R. Martin", CountryOfOrigin = "United States of America", DateOfBirth = "September 20, 1948" };
            var author2 = new Author { Id = 2, Name = "J.R.R. Tolkien", CountryOfOrigin = "United Kingdom", DateOfBirth = "January 3, 1892" };
            var author3 = new Author { Id = 3, Name = "J.K. Rowling", CountryOfOrigin = "United Kingdom", DateOfBirth = "July 31, 1965" };

            var books = new List<Book>
            {
                new Book { Id = 1, Title = "A Game of Thrones", Genre = "High fantasy", Author = author1 },
                new Book { Id = 2, Title = "The Silmarillion", Genre = "Mythopoeia", Author = author2 },
                new Book { Id = 3, Title = "The Lord of the Rings", Genre = "High fantasy, Adventure", Author = author2 },
                new Book { Id = 4, Title = "Harry Potter and the Philosopher's Stone", Genre = "Fantasy", Author = author3 },
                new Book { Id = 5, Title = "Harry Potter and the Deathly Hallows", Genre = "Fantasy", Author = author3 }
            };
            return View(books);
        }
    }
}
