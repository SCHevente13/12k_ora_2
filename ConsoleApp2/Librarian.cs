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
    }
}
