using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Librarian
    {
        public string Name { get; set; }
        private Library Librarby { get; set; }
        public Librarian(string name, Library library)
        {
            Name = name;
            Librarby = library;
        }
        public void Introduce()
        {
            Console.WriteLine($"Name: {Name} | Library: {Librarby.Name}");
        }
        public void AddBook(string title, string author, int pageCount)
        {
            Librarby.AddBook(new Book(title, author, pageCount));
            Console.WriteLine("Added Book");
        }
        public void LendBook(string title)
        {
            Librarby.FindByTitle(title).Borrow();
        }
    }
}
