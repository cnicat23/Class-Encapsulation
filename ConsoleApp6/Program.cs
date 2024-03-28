using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program:Library
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book bookOne = new Book(111, 70, "cirtdan ", "dram");
            Book bookTwo = new Book(98, 140, "sir", "funny");
            Book bookThree = new Book(72, 190, "tom jerry", "Flowery");
            Book bookFour = new Book(197, 205, "kitabbb", "simple");

            library.AddBook(bookOne);
            library.AddBook(bookTwo);
            library.AddBook(bookThree);
            library.AddBook(bookFour);

            library.ShowAllBooks();
            Console.WriteLine("---------------");
            library.GetFilteredBooks(100, 400);
        }
    }
}
