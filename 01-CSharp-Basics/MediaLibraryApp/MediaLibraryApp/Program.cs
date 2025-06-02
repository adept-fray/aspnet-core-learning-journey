
using MediaLibraryApp;

Book audiobook = new AudioBook(20.1);
Book ebook = new EBook(13);

List<Book> books = new List<Book>();
books.Add(ebook);
books.Add(audiobook);

while (true)
{
    Console.WriteLine("Choose an option.");
    Console.WriteLine("1. Search by Author Name.");
    Console.WriteLine("2. Search by Year.");
    Console.WriteLine("3. Exit.");

    string option = Console.ReadLine();
    if(option == "1")
    {
        string authorSearch= Console.ReadLine();
        var filteredByAuthor = books.Where(b => b.Author.Contains(authorSearch, StringComparison.OrdinalIgnoreCase));

        foreach(Book book in filteredByAuthor)
        {
            book.PrintInfo();
        }
        Console.WriteLine("\n");
    }
    else if (option == "2")
    {
        int yearSearch = int.Parse(Console.ReadLine());
        var filteredByYear = books.Where(b => b.Year == yearSearch);

        foreach(Book book in filteredByYear)
        {
            book.PrintInfo();
        }
        Console.WriteLine("\n");
    }
    else if(option == "3")
    {
        break;
    }
    else
    {
        Console.WriteLine("Not Valid option.\n\n");
    }
}



