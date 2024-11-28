using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Currency converter:
            Console.WriteLine("Select currency for conversion");
            Console.WriteLine("Select 1 for USD,2 for EUR,3 for GBP");
            double curr = Convert.ToDouble(Console.ReadLine());
            Console.Write("How much amount you want to convert: ");
            double pkr = Convert.ToDouble(Console.ReadLine());

            switch (curr)
            {
                case 1:
                    Console.WriteLine("RS: " + pkr*280);
                    break;
                case 2:
                    Console.WriteLine("RS: " + pkr*300);
                    break;
                case 3:
                    Console.WriteLine("RS: " + pkr*350);
                    break;
                default:
                    Console.WriteLine("Something went wrong");
                    break;
            }
            Console.ReadLine();


        }
    }
}
