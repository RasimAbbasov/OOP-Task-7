using OOP_Task5.ExtensionMethods;
using System.Drawing;

namespace OOP_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Console.WriteLine("Student ucun DoHomework methodu");
            //Student student = new Student("Filankes Filankesov", 10);
            //student.DoHomework();
            ////--------------------------
            //Console.WriteLine("DesignStudent ucun DoHomeWork methodu");
            //DesignStudent designStudent = new DesignStudent("Filankes Filankesov2", 20);
            //designStudent.DoHomework();
            ////--------------------------
            //Console.WriteLine("ProgrammingStudent ucun DoHomeWork methodu");
            //ProgrammingStudent programmingStudent = new ProgrammingStudent("Filankes Filankesov3", 30);
            //programmingStudent.DoHomework();
            #endregion
            #region Task2
            //do
            //{
            //    Console.WriteLine("Menu:");
            //    Console.WriteLine("1.Square");
            //    Console.WriteLine("2.Rectangular");
            //    Console.WriteLine("0.Quit");
            //    Console.WriteLine("Seciminiz:");
            //    int secim = Convert.ToInt32(Console.ReadLine());
            //    if (secim == 0) { break; }
            //    Figure figure = null;
            //    if (secim == 1)
            //    {
            //        Console.WriteLine("Kvadratin terefini daxil et:");
            //        double side = Convert.ToDouble(Console.ReadLine());
            //        figure = new Square(side);
            //        Console.WriteLine(figure.CalcArea());
            //    }
            //    if (secim == 2)
            //    {
            //        Console.WriteLine("Duzbucaqlinin enini daxil et:");
            //        double width = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("Duzbucaqlinin uzunlugunu daxil et:");
            //        double length = Convert.ToDouble(Console.ReadLine());
            //        figure = new Rectangular(width, length);
            //        Console.WriteLine(figure.CalcArea());
            //    }
            //    if(secim>2 || 0>secim)
            //        Console.WriteLine("Invalid choice");
            //        continue;
            //}
            //while (true);
            #endregion
            #region Task4
            //Celcius celcius = new Celcius(30);
            //Kelvin kelvin = celcius;
            //Console.WriteLine("Celcius degree:" + " " + celcius.Degree);
            //Console.WriteLine("Kelvin degree:" + " " + kelvin.Degree);
            #endregion
            #region Task6 
            string a = "salam,necesen.Yaxsi,sen necesen";
            Console.WriteLine(a.GetSecondWord());
            #endregion
        }
    }
}
