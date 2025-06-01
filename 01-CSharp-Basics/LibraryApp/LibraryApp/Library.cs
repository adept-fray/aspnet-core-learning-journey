using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    internal class Library
    {
        List<Book> list = new List<Book>();

        public void AddBook(Book book)
        {
            list.Add(book);
        }
        public void RemoveBook(Book book)
        {
            list.Remove(book);
        }

        public void PrintBooks()
        {
            foreach (Book book in list)
            {
                if (book.IsClassic())
                {
                    Console.WriteLine("This book is Classic.");
                    book.PrintInfo();
                }
                else
                {
                    Console.WriteLine("This book is Modern.");
                    book.PrintInfo();
                }
            }
        }
    }
}
