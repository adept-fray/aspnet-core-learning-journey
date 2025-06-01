using ConstructorsAndMethods;

Book book1 = new Book();
Book book2 = new Book("book number 2", "Author 2");
Book book3 = new Book("book 3", "Author 3", 1900, 3000);
Book book4 = new Book("book 4", "Author 4", 2000, 3000);

book1.PrintInfo();
book2.PrintInfo();
book3.PrintInfo();
book4.PrintInfo();