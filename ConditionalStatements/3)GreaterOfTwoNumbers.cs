using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_GreaterOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Greater Smaller:
            Console.WriteLine("Greater OR Smaller Check:");
            Console.Write("Enter Your First Number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Your Second Number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is greater and " + num2 + " is smaller");
            }
            else if (num2 > num1)
            {
                Console.WriteLine(num2 + " is greater and " + num1 + " is smaller");
            }
            else
            {
                Console.WriteLine("Both numbers are equal");
            }
            Console.ReadLine();

        }
    }
}
