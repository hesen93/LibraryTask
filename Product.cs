using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double TotalInCome { get; set; }
        public abstract void Sell(Book book);
        public abstract void ShowInfo(Book book);

    }
}
