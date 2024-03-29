using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public class Book : Product 
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(string authorName, int pageCount,string name,double price,int count = 1)
        {
            AuthorName = authorName;
            PageCount = pageCount;
            Name = name;    
            Price = price;
            Id = Utils.GenerateId();
            Count = count;
        }

        public override void Sell(Book book)
        {
            if (book.Count != 0)
            {
                TotalInCome += book.Price;
                book.Count--;
            }
            else
                throw new ProductCountIsZeroException("Satilacaq mehsul qalmayib");
            
        }

        public override void ShowInfo(Book book)
        {
            try
            {
                Console.WriteLine("Book ID : " + book.Id);
                Console.WriteLine("Book name :" + book.Name);
                Console.WriteLine("Author name : " + book.AuthorName);
                Console.WriteLine("Book price : " + book.Price);
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException("Bu Id-de kitab movcud deyil");
            }
            
        }
    }
}
