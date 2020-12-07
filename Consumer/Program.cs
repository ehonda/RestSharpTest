using Consumer.Models;
using Consumer.Models.Extensions;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Consumer
{
    class Program
    {
        static void GetAndPrintBooks(RestClient client)
        {
            Console.WriteLine("GET and print books");

            var books = client
                .Get<IEnumerable<Book>>(new RestRequest("books"))
                .Data ?? Enumerable.Empty<Book>();

            foreach (var book in books)
                Console.WriteLine($"{book.ToBookString()}");

            Console.WriteLine("");
        }

        static void PostBook(RestClient client)
        {
            Console.WriteLine("POST a book");

            var book = new Book
            {
                Id = 2,
                Title = "A Song of Ice and Fire",
                Author = "George R. R. Martin"
            };

            client.Post(new RestRequest("books").AddJsonBody(book));

            Console.WriteLine("");
        }

        static void Main(string[] args)
        {
            var client = new RestClient("https://localhost:3333");

            GetAndPrintBooks(client);
            PostBook(client);
            GetAndPrintBooks(client);
        }
    }
}
