using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_SimpleCalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Simple Calculator:
            Console.WriteLine("Enter two digits and one function");
            Console.Write("Enter First Number: ");
            int numb1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Nummber: ");
            int numb2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select one operator from '+,-,*,/': ");
            char func = Convert.ToChar(Console.ReadLine());

            switch (func)
            {
                case '+':
                    Console.WriteLine(numb1 + numb2);
                    break;
                case '-':
                    Console.WriteLine(numb1 - numb2);
                    break;
                case '*':
                    Console.WriteLine(numb1 * numb2);
                    break;
                case '/':
                    Console.WriteLine(numb1 / numb2);
                    break;
                default:
                    Console.WriteLine("Some thing went wrong");
                    break;

            }
            Console.ReadLine();



        }
    }
}
