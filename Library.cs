using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Example3
{
	public class Library
	{
        
        List<Book> books = new List<Book>();
		public int bookLimit;

		public int BookLimit
		{
			get { return bookLimit; }
			set 
			{
				if (value >= 100)
					throw new CapacityLimitException("100-den az olmalidir");
				else
					bookLimit = value;
			}
		}
		public Library(int bookLimit)
		{
            BookLimit = bookLimit;
		}

		public void AddBook(Book book)
		{
			if(books.Count < 100)
                books.Add(book);
			else
                throw new CapacityLimitException("Artiq 99 kitab movcuddur.");

        }
		public Book GetBookById(int id)
        {
			Book book = null;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Id == id)
                    book = books[i];
            }
			return book;
		}
		public void RemoveById(int id)
		{
            Book book = null;
            for (int i = 0; i < books.Count; i++)
            {
				if (books[i].Id == id)
					book = books[i];
				
            }
			if (book == null)
				throw new NotFoundException("Bu Id - de kitab movcud deyil");
			else
				books.Remove(book);
			
        }

       
    }
}