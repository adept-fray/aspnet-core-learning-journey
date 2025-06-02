using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaLibraryApp
{
    internal class AudioBook : Book
    {
        public double Length { get; set; }

        public AudioBook() : base()
        {
            Length = 0;
        }

        public AudioBook(double length) : base()
        {
            Length = length;
        }

        public AudioBook(string title, string author, int year, decimal price, double length) : base(title, author, year, price)
        {
            Length = length;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"AudioBook title: {Title}, author: {Author}, price{Price:C}, length: {Length:F2}.");
        }
    }
}
