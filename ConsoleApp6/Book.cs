using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Book : Product
    {
        public string Genre;


        public Book(int price, int no, string name, string genre) : base(price, no, name) 
        {
            Genre = genre;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Book No: {No} ,Name: {Name}, Price: {Price}, Count: {Count}, Genre: {Genre}");
        }

    }
}
