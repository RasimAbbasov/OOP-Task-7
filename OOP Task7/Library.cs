using OOP_Task7.Exceptions;

namespace OOP_Task7
{
    public class Library
    {
        private int BookLimit { get; set; }
        List<Book> Books { get; set; }
        public Library(int booklimit)
        {
            BookLimit = booklimit;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if (BookLimit>0)
            {
                Books.Add(book);
                Console.WriteLine("Kitab elave edildi");
                BookLimit--;
            }
            else
            {
                throw new CapacityLimitException("Kitabxana doludur");
            }
        }
        public void GetBookById(int id)
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }
            var result = Books.Find(book => book.Id == id);
            if(result == null) 
            {
                Console.WriteLine("Kitabların heç biri bu id-e beraber deyil");
            }
            Console.WriteLine(result);
        }
        public void RemoveById(int id) 
        {
            if (id == null)
            {
                throw new NullReferenceException();
            }
            var RemovedBook = Books.Find(book => book.Id == id);
            if (RemovedBook == null)
            {
                throw new NotFoundException("Kitab tapilmadi");
            }
            Books.Remove(RemovedBook);
        }
    }
}
