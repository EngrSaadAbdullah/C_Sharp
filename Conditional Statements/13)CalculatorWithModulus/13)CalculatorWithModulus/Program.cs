using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CalculatorWithModulus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calculator with modulus:
            Console.WriteLine("Enter two digits and one function");
            Console.Write("Enter First Number: ");
            double mod1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Nummber: ");
            double mod2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Select one operator from '+,-,*,/,%': ");
            char modulus = Convert.ToChar(Console.ReadLine());

            switch (modulus)
            {
                case '+':
                    Console.WriteLine(mod1 + mod2);
                    break;
                case '-':
                    Console.WriteLine(mod1 - mod2);
                    break;
                case '*':
                    Console.WriteLine(mod1 * mod2);
                    break;
                case '/':
                    Console.WriteLine(mod1 / mod2);
                    break;
                case '%':
                    Console.WriteLine((mod1/mod2)*100);
                    break;
                default:
                    Console.WriteLine("Some thing went wrong");
                    break;

            }
            Console.ReadLine();



        }
    }
}
