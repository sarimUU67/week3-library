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

        // Create a constructor for object 'Book'
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

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
            Book book = new Book("C# for beginners", "Bill Gates", "12345678");

            // New instance called 'book1'
            Book book1 = new Book("C# Methods and Classes", "Microsoft", "55667778");

            // Output the book information to the console
            book.DisplayInfo();
            book1.DisplayInfo();
        }
    }
}
