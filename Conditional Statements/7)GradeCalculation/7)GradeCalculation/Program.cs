using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_GradeCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Grade Calculation;/
            Console.WriteLine("Enter 3 subject's marks");

            Console.WriteLine("1) Enter 1st subject marks");
            Console.Write("Maths: ");
            double sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2) Enter 2nd subject marks");
            Console.Write("English: ");
            double sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("3) Enter 3rd subject marks");
            Console.Write("Urdu: ");
            double sub3 = Convert.ToInt32(Console.ReadLine());

            double obtain = sub1 + sub2 + sub3;
            double perc = (obtain/300)*100;

            if (perc >= 80 && perc<= 100)
            {
                Console.WriteLine("Your Grade Is 'A+'");
            }
            else if (perc >= 70 && perc <= 79)
            {
                Console.WriteLine("Your Grade Is 'A'");
            }
            else if (perc >= 60 && perc <= 69)
            {
                Console.WriteLine("Your Grade Is 'B'");
            }
            else if (perc >= 50 && perc <= 59)
            {
                Console.WriteLine("Your Grade Is 'C'");
            }
            else if (perc >= 40 && perc <= 49)
            {
                Console.WriteLine("Your Grade Is 'C'");
            }
            else
            {
                Console.WriteLine("You Are Fail");
            }
            Console.WriteLine("Your percentage is "+perc);
            Console.ReadLine();


        }
    }
}
