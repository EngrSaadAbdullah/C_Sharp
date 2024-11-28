using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DivisibilityCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Divisibility Check
            Console.WriteLine("Enter any number to check divisibility of 5");
            double num5 = Convert.ToInt32(Console.ReadLine());
            double number5 = num5 / 5;

            if (num5 % 5 == 0)
            {
                Console.WriteLine(num5+" is divisible by 5");
            }
            else
            {
                Console.WriteLine(num5+" isn't divisible by 5");
            }
            Console.WriteLine("Answer: " + number5);
            Console.ReadLine();


            Console.WriteLine("Enter any number to check divisibility of 11");
            double num11 = Convert.ToInt32(Console.ReadLine());
            double number11 = num11 / 11;

            if (num11 % 11 == 0)
            {
                Console.WriteLine(num11+" is divisible by 11");
            }
            else
            {
                Console.WriteLine(num11+" isn't divisible by 11");
            }
            Console.WriteLine("Answer: " + number11);
            Console.ReadLine();



        }
    }
}
