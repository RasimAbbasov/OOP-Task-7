namespace OOP_Task5
{
    public class Celcius
    {
        public double Degree { get; set; }
        public Celcius(double degree) 
        {
         Degree = degree;
        }
        public static implicit operator Kelvin(Celcius degree) 
        {
            return new Kelvin(degree.Degree + 273);
        }
    }
    public class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Celcius(Kelvin degree) 
        {
            return new Celcius(degree.Degree - 273);
    }   }
}
