using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Product
    {
        private int _price;
        private int _count;
        public int No;
        public string Name;

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
            }
        }

        public Product(int price, int no, string name)
        {
            Name = name;
            No = no;
            _price = price;
        }



    }
}
