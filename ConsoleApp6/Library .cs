using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Library
    {

        //public Library[] Librarys = new Library[] { };


        //public void GetFilteredBooks(string genre)
        //{

        //}

        //public void ShowAllBooks()
        //{

        //}


        private Book[] Books = new Book[] { };


        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public Book[] GetFilteredBooks(string genre)
        {
            Book[] NewBooks = new Book[] { };
            int count = 0;
            if (Books.Length > 0)
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    if (Books[i].Genre == genre)
                    {
                        count = 1;
                        Array.Resize(ref NewBooks, NewBooks.Length + 1);
                        NewBooks[NewBooks.Length - 1] = Books[i];
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("janr yoxdu");
                }
            }
            else
            {
                Console.WriteLine("kitab yoxdu");
            }
            return NewBooks;
        }




        public void GetFilteredBooks(int minPrice, int maxPrice)
        {
            int count = 0;
            if (Books.Length > 0)
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    if (Books[i].Price >= minPrice && Books[i].Price <= maxPrice)
                    {
                        count = 1;
                        Console.WriteLine($"{Books[i].Name} \n{Books[i].No}\n{Books[i].Price} \n{Books[i].Count} \n{Books[i].Genre}");
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("bu qiymet araliginda kitab yoxdu");
                }
            }
            else
            {
                Console.WriteLine("kitab yoxdu");
            }
        }
        public void ShowAllBooks()
        {
            if (Books.Length > 0)
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    Console.WriteLine($"Name:{Books[i].Name} No: {Books[i].No} Price:{Books[i].Price} Count:{Books[i].Count} Genre:{Books[i].Genre}");
                }
            }
            else
            {
                Console.WriteLine("Kitab yoxdur!");
            }
        }
    }
}
