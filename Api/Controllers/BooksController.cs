using Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private static readonly List<Book> _books = new[]
            {
                new Book
                {
                    Id = 0,
                    Title = "Grafik und Zeichnungen",
                    Author = "M. C. Escher"
                },

                new Book
                {
                    Id = 1,
                    Title = "Tales of Ordinary Madness",
                    Author = "Charles Bukowsky"
                }
            }
            .ToList();

        public BooksController() {}

        [HttpGet]
        public IEnumerable<Book> Get() => _books;

        [HttpPost]
        public void Post(Book book) => _books.Add(book);
    }
}
