namespace OOP_Task6.Exceptions
{
        public class CapacityLimitException : Exception 
        {
         public CapacityLimitException(string message): base(message) { }
        }
    public class NotFoundException : Exception
    {
        public NotFoundException(string message) : base(message) { }
    }
    public class ProductCountIsZeroException : Exception
    {
        public ProductCountIsZeroException(string message) : base(message) { }
    }
}
