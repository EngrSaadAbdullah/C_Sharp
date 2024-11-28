using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_BMICategory
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //BMI Category:
            Console.WriteLine("Enter your weight");
            Console.Write("Weight in Kg is: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight <= 35)
            {
                Console.WriteLine("You are underweight");
            }
            else if (weight <=55)
            {
                Console.WriteLine("Your weight is normal");
            }
            else if (weight <= 70)
            {
                Console.WriteLine("You are overweight");
            }
            else
            {
                Console.WriteLine("You are obese");
            }
            Console.ReadLine();

        }
    }
}
