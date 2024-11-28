using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_NumberClassification
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Number classification +/- even and odd:
            Console.WriteLine("Enter a number to check +even or -even and +odd or -odd");
            int numb = Convert.ToInt32(Console.ReadLine());

            if (numb > 0 && numb % +2 == 0)
            {
                Console.WriteLine("the number is +even");
            }
            else if (numb > 0 && numb % +1 ==0)
            {
                Console.WriteLine("the number is +odd");
            }
            else if (numb % -2 == 0)
            {
                Console.WriteLine("the number is -even");
            }
            else
            {
                Console.WriteLine("the number is -odd");
            }
            Console.ReadLine();



        }
    }
}
