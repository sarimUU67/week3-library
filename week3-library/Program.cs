using week3_library;

class Program
{
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
