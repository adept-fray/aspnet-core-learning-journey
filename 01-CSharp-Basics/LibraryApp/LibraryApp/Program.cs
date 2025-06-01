using LibraryApp;

Library library = new Library();

Book book = new Book("ok", "okauthor", DateOnly.Parse("2025-02-02"));

library.AddBook(book);

Book book1 = new Book("Title new", "Author new", DateOnly.Parse("2025-02-02"));
library.AddBook(book1);


Book book2 = new Book("nsoo", "Author nsoo", DateOnly.Parse("2025-02-02"));
library.AddBook(book2);


library.PrintBooks();