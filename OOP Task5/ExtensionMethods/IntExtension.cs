namespace OOP_Task5.ExtensionMethods
{
    internal static partial class Extension
    {
        public static bool IsOdd(this int a) 
        {
            if (a % 2 != 0) 
            {
                return true;
            }
            
             return false;
        }
        public static bool IsEven(this int a) 
        {
            if (a % 2 == 0) 
                return true;
            
            return false;
        }
    }
}
