using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        private decimal _price;

        public decimal Price { get { return _price; } set { _price = value < 0 ? 0: value; } }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Book has title: {Title}, author: {Author}, price{_price}");
        }
    }
}
