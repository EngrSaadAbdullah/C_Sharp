using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_DrivingLicenseEligibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Eligibility for driving license:
            Console.WriteLine("Enter your age");
            int drive = Convert.ToInt32(Console.ReadLine());

            if (drive >= 18)
            {
                Console.WriteLine("You are able for driving");
            }
            else
            {
                Console.WriteLine("You aren't able for driving");
            }
            Console.ReadLine();

        }
    }
}
