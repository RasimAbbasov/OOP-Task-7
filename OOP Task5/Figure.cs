using OOP_Task5;

namespace OOP_Task5
{
    abstract class Figure
    {
        public abstract double CalcArea();
    }
}   internal class Square : Figure
{
    private double side;
    public double Side
    {
        get => side;

        set
        {
            if (value < 0)
                Console.WriteLine("Side menfi ola bilmez");
            side = value;
        }
    }
    public Square(double side)
    {
        if (side < 0)
            Console.WriteLine("Side menfi ola bilmez");
        this.side = side;
    }
    public override double CalcArea()
    {
        return side * side;
    }
}
    internal class Rectangular : Figure
    {
     private double width;
    private double length;
        public double Width
        {
            get => width;

            set
            {
                if (value < 0)
                    Console.WriteLine("Eni menfi ola bilmez");
                width = value;
            }
        }
        public double Length
        {
            get => length;

            set
            {
                if (value < 0)
                    Console.WriteLine("Uzunlugu menfi ola bilmez");
                length = value;
            }
        }
        public Rectangular(double width, double length) 
        {
         if((width < 0) || (length < 0))
                Console.WriteLine("Width ve Length menfi ola bilmez");
          this.width = width;
          this.length = length;
        }
        public override double CalcArea() 
        {
         return length*width;
        }
    }

           
