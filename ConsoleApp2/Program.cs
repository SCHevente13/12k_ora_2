namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Book book1 = new Book("Hairy Porter The Dumb Stone", "JK.", 310);
            Book book2 = new Book("Art of Fart", "Sun Who?", 194);
            Console.WriteLine(book1.Describe());
            Console.WriteLine(book2.Describe());
            if (book1.IsLong())
            {
                Console.WriteLine("First Book is long.");
            }
            else
            {
                Console.WriteLine("First Book is not long.");
            }
            if (book2.IsLong())
            {
                Console.WriteLine("Second Book is long.");
            }
            else
            {
                Console.WriteLine("Second Book is not long.");
            }
            Book book3 = new Book("My Diary", "Not the Austrian Painter");
            if (book1.Borrow())
            {
                Console.WriteLine("You borrowed the book.");
            }
            else
            {
                Console.WriteLine("You couldn't borrow the book.");
            }
            if (book1.Borrow())
            {
                Console.WriteLine("You borrowed the book.");
            }
            else
            {
                Console.WriteLine("You couldn't borrow the book.");
            }
            Library library = new Library("The Library of Hornets & Dumplings");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);


        }
    }
}
