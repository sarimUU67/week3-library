using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_library
{
    internal class Book
    {
        string Title;
        string Author;
        string ISBN;

        static void Main(string[] args)
        {
            // Creating a new instance of the Book class
            Book book = new Book();

            // Info on the book in our library
            book.Title = "C# for beginners";
            book.Author = "BillGates";
            book.ISBN = "12345678";

            // New instance called 'book1'
            Book book1 = new Book();
            book1.Title = "C# Methods and classes";
            book1.Author = "Microsoft";
            book1.ISBN = "55667778";

            // Output the info for 'book' to the console
            Console.WriteLine($"Book title: {book.Title}");
            Console.WriteLine($"Book author: {book.Author}");
            Console.WriteLine($"Book ISBN: {book.ISBN}");
            Console.WriteLine();

            // Output the infor for 'book1' to the console
            Console.WriteLine($"Book title: {book1.Title}");
            Console.WriteLine($"Book author: {book1.Author}");
            Console.WriteLine($"Book ISBN: {book1.ISBN}");

        }
    }
}
