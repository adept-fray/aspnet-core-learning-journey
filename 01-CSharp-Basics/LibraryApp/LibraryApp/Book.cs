using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateOnly Date { get; set; }

        public Book(string title, string author, DateOnly date)
        {
            Title = title;
            Author = author;
            Date = date;
        }

        public bool IsClassic()
        {
            return Date < DateOnly.Parse("1990-01-01");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Date: {Date}.");
        }
    }
}
