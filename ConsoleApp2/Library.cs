using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Library
    {
        public string Name { get; set; }
        private List<Book> books { get; set; }
        public int BookCount { get; }
        public Library(string name)
        {
            Name = name;
            books = new List<Book>();
            BookCount = books.Count;
        }
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void PrintAll()
        {
            foreach (Book book in books)
            {
                Console.WriteLine(book.Describe());
            }
        }
        public Book FindByTitle(string title)
        {
            foreach (Book book in books)
            {
                if (book.Title == title)
                {
                    return book;
                }
            }
            return null;
        }
        public Book FindByAuthor(string author)
        {
            foreach (Book book in books)
            {
                if (book.Author == author)
                {
                    return book;
                }
            }
            return null;
        }
        public int TotalPages()
        {
            int total = 0;
            foreach(Book book in books)
            {
                total += int.Parse(book.Describe().Split(": ")[3]);
            }
            return total;
        }
        public double AveragePages()
        {
            return TotalPages() / BookCount;
        }
        public List<Book> AvailableBooks()
        {
            List<Book> avaBooks = new List<Book>();
            foreach (Book book in books)
            {
                if (book.IsAvailable)
                {
                    avaBooks.Add(book);
                }
            }
            return avaBooks;
        }
    }
}
