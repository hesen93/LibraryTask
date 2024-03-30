namespace Example3
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        protected double TotalInCome { get; set; }
        public abstract void Sell();
        public abstract string ShowInfo();

    }
}
