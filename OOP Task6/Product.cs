namespace OOP_Task6
{
    public abstract class Product
    {   private readonly int _id;
        private readonly int _idCounter=0;
        public int Id => _id;
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalInCome { get; set; }
        protected Product(string name,decimal price,int count) 
        {
         Name = name;
         Price = price;
         TotalInCome = 0;
         Count=count;
        }
        public abstract void Sell();
        public abstract void ShowInfo();

    }
}
