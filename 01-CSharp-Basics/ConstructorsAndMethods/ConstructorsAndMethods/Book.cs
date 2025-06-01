using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsAndMethods
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        private decimal _price;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Price can not be negative. Keeping old value");
                }
                else
                {
                    _price = value;
                }
            }
        }

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Year = 0;
            Price = 0;
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Price = 0;
        }

        public Book(string title, string author, int year, decimal price)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
        }

        public bool IsClassic()
        {
            return Year < 1990;
        }

        public void PrintInfo()
        {
            if(IsClassic())
            {
                ApplyDiscount(20);
                Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Price: {Price:F2}.");
            }
            else
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}, Price: {Price:F2}.");
            }
        }

        public void ApplyDiscount(decimal percent)
        {
            if(percent > 0 && percent <= 100)
            {
                decimal discountAmount = (_price * percent) / 100;
                _price -= discountAmount;
            }
            else
            {
                Console.WriteLine("Invalid discount percent");
            }
        }
    }
}
