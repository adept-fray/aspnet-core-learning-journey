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

        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Year = 0;
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Year = 0;
        }

        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public bool IsClassic()
        {
            return Year < 1990;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {Year}.");
        }
    }
}
