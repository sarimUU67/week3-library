using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_library
{
    internal class Book
    {
        // Private variables
        private string title;
        private string author;
        private string isbn;

        // Properties to allow access to private variables
        public string Title
        {
            get { return title; } // get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }


        // Create a constructor for object 'Book'
        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            Title = bookTitle;
            Author = bookAuthor;
            ISBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
