using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Even Odd:
            Console.WriteLine("Enter a number to check even or odd");
            int numb = Convert.ToInt32(Console.ReadLine());
            if (numb % 2 == 0)
            {
                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }
            Console.ReadLine();

        }
    }
}
