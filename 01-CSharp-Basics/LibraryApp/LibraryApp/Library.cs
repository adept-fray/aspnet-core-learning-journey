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
                book.PrintInfo();
            }
        }
    }
}
