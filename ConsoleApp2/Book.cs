using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Book
    {
        public static int Count = 0;
        public string Title { get; set; }
        public string Author { get; set; }
        private int PageCount { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            if (pageCount < 0)
            {
                PageCount = 0;
            }
            else
            {
                PageCount = pageCount;
            }
            Count++;
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            PageCount = 0;
            Count++;
        }
        public string Describe()
        {
            return $"Title: {Title} | Author: {Author} | Page Count: {PageCount}";
        }
        public bool IsLong()
        {
            if ( PageCount > 300)
            {
                return true;
            } 
            return false;
        }
        public bool Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                return true;
            }
            return false;
        }
        public void Return()
        {
            IsAvailable = true;
        }
    }
}
