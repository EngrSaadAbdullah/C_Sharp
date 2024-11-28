using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BasicIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Positive, Negative or zero:
            Console.WriteLine("Enter the number to check +ive or -ive");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative");
            }
            else
            {
                Console.WriteLine("The number is zero");
            }
            Console.ReadLine();


        }
    }
}
