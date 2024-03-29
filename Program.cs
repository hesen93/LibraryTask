using Example3;

Book book = new("Cingiz Abdullayev", 457, "Balkan Sindromu", 6.5, 3);
Book book2 = new("Viktor Huqo", 898, "Sefiller", 18.7);
book.ShowInfo(book);
Library library = new Library(87);
library.AddBook(book2);
library.AddBook(book);
book.ShowInfo(library.GetBookById(2));
library.RemoveById(3);
book.Sell(book);
book.Sell(book2);
Console.WriteLine(book.Count);
Console.WriteLine(book2.Count);
book.Sell(book2);



