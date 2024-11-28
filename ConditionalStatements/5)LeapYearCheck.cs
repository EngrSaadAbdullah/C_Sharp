using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_LeapYearCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Leap Year Check:
            Console.Write("Enter a year to check leap year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
            Console.ReadLine();

        }
    }
}
