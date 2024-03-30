using Example3;

Book book = new("Cingiz Abdullayev", 457, "Balkan Sindromu", 6.5, 3);
Book book2 = new("Viktor Huqo", 898, "Sefiller", 18.7);

Utils.Info(book.ShowInfo());
Library library = new Library(87);
library.AddBook(book);
library.AddBook(book2);


try
{
    var specificBook = library.GetBookById(2);
    specificBook.ShowInfo();
}
catch (Exception ex)
{
    Utils.Error(ex.Message);
}


try
{
    library.RemoveById(3);
}
catch (Exception ex)
{
    Utils.Error(ex.Message);
}


try
{
    book.Sell();
    book2.Sell();
    Utils.Info(book.Count.ToString());
    Utils.Info(book2.Count.ToString());
    book2.Sell();
}
catch (Exception ex)
{
    Utils.Error(ex.Message);
}
