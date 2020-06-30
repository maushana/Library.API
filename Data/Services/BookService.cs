using Library.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Data.Services
{
    public class BookService : IBookService
    {
        private readonly List<Book> _books;

        public BookService()
        {
            _books = new List<Book>()
            {
                new Book()
                {
                    Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Title = "Manging Oneself",
                    Description = "We live in an age of unprecedented opportunity...",
                    Author = "Peter Ducker",
                },
                new Book()
                {
                    Id = new Guid("117366b8-3541-4ac5-8732-860d698e26a2"),
                    Title = "Evolutionary Psychology",
                    Description = "Evoloutionary Psychology: The New Science of the Mind...",
                    Author = "David Buss",
                },
                new Book()
                {
                    Id = new Guid("66ff5116-bcaa-4061-85b2-6f58fbb6db25"),
                    Title = "How to Win Friends & Influence People",
                    Description = "Millions of people around the world have improved their...",
                    Author = "Dale Carnegie",
                },
                new Book()
                {
                    Id = new Guid("cd5089dd-9754-4ed2-b44c-488f533243ef"),
                    Title = "The Selfish Gene",
                    Description = "Professor Dawkins articulates a gene's eye view of...",
                    Author = "Richard Dawkins",
                },
                new Book()
                {
                    Id = new Guid("d81e0829-55fa-4c37-b62f-f578c692af78"),
                    Title = "The Lessons of History",
                    Description = "Will and Ariel Durant have successded in distilling...",
                    Author = "Will & Ariel Durant",
                }
            };
        }

        public Book Add(Book newBook)
        {
            _books.Add(newBook);
            return newBook;
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book GetById(Guid id)
        {
            return (Book)_books.Find(b => b.Id == id);
        }

        public void Remove(Guid id)
        {
            var remBook = (Book)_books.Find(b => b.Id == id);
            if (remBook != null)
            {
                _books.Remove(remBook);
            }
        }
    }
}
