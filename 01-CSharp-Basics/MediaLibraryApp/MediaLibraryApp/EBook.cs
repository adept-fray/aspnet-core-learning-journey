using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    internal class EBook : Book
    {
        public int Size { get; set; }

        public EBook() : base()
        {
            Size = 0;
        }

        public EBook(int size) : base()
        {
            Size = size;
        }

        public EBook(string title, string author, int year, decimal price, int size) : base(title, author, year, price)
        {
            Size = size;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"EBook title: {Title}, author: {Author}, price{Price}, size: {Size}.");
        }
    }
}
