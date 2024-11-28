using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_EmployeeBonusCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Employee Bonus Calculation:
            Console.WriteLine("Enter your experirnce in job from 1 to 8 years");
            Console.Write("Enter your experience: ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            if (bonus >= 1 && bonus <2)
            {
                Console.WriteLine("You work here for "+bonus+" years, so you get 2% increment in salary");
            }
            else if (bonus >= 2 && bonus <3)
            {
                Console.WriteLine("You work here for "+bonus+" years, so you get 4% increment in salary");
            }
            else if (bonus >= 3 && bonus <4)
            {
                Console.WriteLine("You work here for "+bonus+" years, so you get 6% increment in salary");
            }
            else if (bonus >= 4 && bonus <5)
            {
                Console.WriteLine("You work here for "+bonus+" years, so you get 8% increment in salary");
            }
            else if (bonus >= 5 && bonus <=8)
            {
                Console.WriteLine("You work here for "+bonus+" years, so you get 10% increment in salary");
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
            Console.ReadLine();


        }
    }
}
