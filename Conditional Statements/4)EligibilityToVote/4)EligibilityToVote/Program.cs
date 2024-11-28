using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EligibilityToVote
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // Eligibility to vote:
            Console.WriteLine("Enter your age to check for voting");
            int vote = Convert.ToInt32(Console.ReadLine());

            if (vote >= 18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else
            {
                Console.WriteLine("You aren't eligible for voting");
            }
            Console.ReadLine();

        }
    }
}
