﻿using week3_library;

class Program
{
    static void Main(string[] args)
    {
        // Creating a new instance of the Book class
        Book book = new Book("C# for beginners", "Bill Gates", "12345678");
        Book book1 = new Book("C# Methods and Classes", "Microsoft", "55667778");

        // Output the book information to the console
        book.DisplayInfo();
        book1.DisplayInfo();

        // Create new instances of the Member class
        Member member = new Member(1, "John Smith", "1 High Street", 0790090090);
        Member member1 = new Member(2, "Mary Jones", "102 Garden Road", 0790345666);

        Console.WriteLine("Current library members");
        member.DisplayInfo();
        member1.DisplayInfo();

    }
}
