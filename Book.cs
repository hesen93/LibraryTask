namespace Example3
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }


        public Book(string authorName, int pageCount, string name, double price, int count = 1)
        {
            AuthorName = authorName;
            PageCount = pageCount;
            Name = name;
            Price = price;
            Id = Utils.GenerateId();
            Count = count;
        }

        public override void Sell()
        {
            if (Count != 0)
            {   
                TotalInCome += Price;
                Count--;
            }
            else
                throw new ProductCountIsZeroException("Satilacaq mehsul qalmayib");
        }

        public override string ShowInfo()
        {
            return $"{nameof(Book)} {nameof(Id)}: {Id}\n" +
                   $"{nameof(Book)} {nameof(Name)} {Name}\n" +
                   $"{nameof(AuthorName)} {AuthorName}\n" +
                   $"{nameof(Book)} {nameof(PageCount)} {PageCount}";
        }
    }
}
