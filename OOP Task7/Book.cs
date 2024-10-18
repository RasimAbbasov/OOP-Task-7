using OOP_Task7.Exceptions;

namespace OOP_Task7
{
    public class Book:Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(string name, decimal price, string authorname, int pagecount,int count) : base(name, price,count)
        {
            AuthorName = authorname;
            PageCount = pagecount;
        }

        public override void ShowInfo()
        {
                Console.WriteLine("Kitab haqqinda melumatlar:");
                Console.WriteLine($"Kitabin adi:{Name}");
                Console.WriteLine($"Qiymeti:{Price}");
                Console.WriteLine($"Yazici:{AuthorName}");
                Console.WriteLine($"Sehife sayi:{PageCount}");
                Console.WriteLine($"Product sayi:{Count}");
            
        }
        public override void Sell()
        {
            if (Count <= 0)
            {
                throw new ProductCountIsZeroException("Mehsul tukenib,satmaq mumkun deyil!");
            }
            Count -= 1;
            TotalInCome += Price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Author: {AuthorName}, Page Count: {PageCount},Count: {Count}";
        }
    }
}
