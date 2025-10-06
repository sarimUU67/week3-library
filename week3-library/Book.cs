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

        void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

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

            // Output the book information to the console
            book.DisplayInfo();
            book1.DisplayInfo();
        }
    }
}
