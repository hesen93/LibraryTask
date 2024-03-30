namespace Example3
{
    public class Library
    {

        private int _bookLimit;
        public int BookLimit
        {
            get { return _bookLimit; }
            set
            {
                if (value > 100)
                    throw new CapacityLimitException();
                else
                    _bookLimit = value;
            }
        }
        public List<Book> Books { get; set; } = new();

        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
        }

        public void AddBook(Book book)
        {
            if (Books.Count <= BookLimit)
                Books.Add(book);
            else
                throw new CapacityLimitException();
        }
        public Book GetBookById(int id)  // Books.FirstOrDefault(x => x.Id == id)!;
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Id == id)
                    return Books[i];
            }
            throw new NotFoundException($"{id}-li kitab tapilmadi");
            //return null;
        }

        public void RemoveById(int id)
        {
            var book = GetBookById(id);
            Books.Remove(book);
        }
    }
}