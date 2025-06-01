using ClassesAndObjects;

Console.WriteLine("Hello, World!");

Book book1 = new Book("book1", "book1Author", DateOnly.Parse("2025-01-01"));
Book book2 = new Book("book2", "book2Author", DateOnly.Parse("2025-02-02"));
Book book3 = new Book("book3", "book3Author", DateOnly.Parse("2025-03-03"));


book1.PrintInfo();
book2.PrintInfo();
book3.PrintInfo();