using OOP_Task6.Exceptions;

namespace OOP_Task6
{
    public class Book : Product
    {
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book(string name, decimal price,int count,string authorname, int pagecount) : base(name, price,count)
        {
            AuthorName = authorname;
            PageCount = pagecount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Kitabin adi:{Name}");
            Console.WriteLine($"Qiymeti:{Price}");
            Console.WriteLine($"Yazici:{AuthorName}");
            Console.WriteLine($"Sehife sayi:{PageCount}");
        }
        public override void Sell()
        {
            if (Count <= 0) 
            {
             throw new ProductCountIsZeroException("Mehsul tukenib,satmaq mumkun deyil!");
            }
            Count-=1;
            TotalInCome += Price;
        }
    }
}
