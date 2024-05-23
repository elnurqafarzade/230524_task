using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230524_task
{
    internal class Library
    {
        public Book[] Books = new Book[0];

        public void AddBook(Book book) 
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public Book[] GetFilteredBooks(string genreName)
        {
            Book[] filteredBooks = Array.Empty<Book>();
            foreach (var book in Books)
            {
                if (book.Genre.ToLower() == genreName.ToLower())
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            }
            return filteredBooks;
        }
        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book[] filteredBooks = Array.Empty<Book>();
            foreach (var book in Books)
            {
                if (book.Price >= minPrice && book.Price <= maxPrice)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = book;
                }
            }
            return filteredBooks;
        }

    }
}
