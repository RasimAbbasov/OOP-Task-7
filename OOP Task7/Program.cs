namespace OOP_Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Book book1 = new Book("Kitab1",150,"Filankes1",50,count: 1);        
          Book book2 = new Book("Kitab2", 100, "Filankes2",100, count: 3);
          Book book3 = new Book("Kitab3", 500, "Filankes3",200, count: 5);
          Library library = new Library(5);
            //--------------------
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            //--------------------
            book1.ShowInfo();
            Console.WriteLine("----------------------");
            book2.ShowInfo();
            Console.WriteLine("----------------------");
            book3.ShowInfo();
            Console.WriteLine("----------------------");
            //--------------------
            book1.Sell();
            book2.Sell();
            book1.ShowInfo();
            //--------------------
            Console.WriteLine("----------------------");
            Console.WriteLine("Tapilmis kitab:");
            library.GetBookById(2);
            //--------------------
            Console.WriteLine("----------------------");
            library.RemoveById(2);
            library.GetBookById(2);
        }
    }
}
