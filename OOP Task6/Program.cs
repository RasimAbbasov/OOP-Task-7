using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using OOP_Task6.Enum;
using OOP_Task6.Exceptions;
namespace OOP_Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Person person1 = new("Rasim", "Abbasov", 18);
            //Person person2 = new("Filankes", "Filankesov", 25);
            //Person person3 = new("Filankes2", "Filenkesov2", 55);
            //Person[] people = {person1, person2, person3};
            //Array.Sort(people);
            //foreach (var item in people) 
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion
            #region Task2
            //double amount;
            //Console.WriteLine("1.Azn to Usd");
            //Console.WriteLine("2.Azn to Eur");
            //Console.WriteLine("3.Azn to Try");
            //int ToThisCurrency=Convert.ToInt32(Console.ReadLine());
            //if (ToThisCurrency < 1 || ToThisCurrency <= 3)
            //{
            //    switch (ToThisCurrency)
            //    {
            //        case (int)Currency.Usd:
            //            Console.WriteLine("Cevrilecek mebleg:");
            //            amount = Convert.ToDouble(Console.ReadLine());
            //            Exchange(amount);
            //            break;
            //        case (int)Currency.Eur:
            //            Console.WriteLine("Cevrilecek mebleg:");
            //            amount = Convert.ToDouble(Console.ReadLine());
            //            Exchange(amount);
            //            break;
            //        case (int)Currency.Try:
            //            Console.WriteLine("Cevrilecek mebleg:");
            //            amount = Convert.ToDouble(Console.ReadLine());
            //            Exchange(amount);
            //            break;
            //    }
            //}
            //else
            //{ throw new IndexOutOfRangeException(); }
            
                    
            
            // void Exchange(double azn) 
            //{
            //    if (ToThisCurrency==1)
            //    {
            //        Console.WriteLine("Cevrilmis mebleg:"+" "+azn * 0.59);
            //    }
            //    if (ToThisCurrency==2)
            //    {
            //        Console.WriteLine("Cevrilmis mebleg:"+" "+azn * 0.54);
            //    }
            //    if (ToThisCurrency==3)
            //    {
            //        Console.WriteLine("Cevrilmis mebleg:"+" "+azn * 20.17);
            //    }
            //}
            #endregion
            #region Task3
            try
            {
                Book book1 = new Book("Kitab1", 100, 5, "Mark Twain", 90);
                Book book2 = new Book("Kitab2", 150, 0, "Agatha Christie", 100);
                Book[] Array = { book1, book2 };
                book1.ShowInfo();
                Console.WriteLine(book1.Count);//manual formada sayin gore bilek deye yazdim
                Console.WriteLine("Total income:" + " " + book1.TotalInCome);
                Console.WriteLine("------------------------"); 
                book1.Sell();
                book1.ShowInfo();
                Console.WriteLine(book1.Count);
                Console.WriteLine("Total income:"+" "+book1.TotalInCome);
                Console.WriteLine("------------------------");
                book2.ShowInfo();
                book2.Sell();//exception verecek
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("xeta bash verdi!"+ex.Message);
            }

            #endregion
        }
    }
}
