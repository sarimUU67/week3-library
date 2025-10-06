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

            // Outputting the info to the console
            Console.WriteLine($"Book title: {book.Title}");
            Console.WriteLine($"Book author: {book.Author}");
            Console.WriteLine($"Book ISBN: {book.ISBN}");

        }
    }
}
