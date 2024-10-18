using System.Reflection.Metadata.Ecma335;

namespace OOP_Task7
{
    public abstract class Product
    {
        private static int _id;
        public int Id;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalInCome { get; set; }
        public abstract void Sell();
        public abstract void ShowInfo();
        protected Product(string name,decimal price,int count)
        {
            Name = name;
            Price = price;
            Count = count;
            _id++;
            Id = _id;
        }
        
    }
}
