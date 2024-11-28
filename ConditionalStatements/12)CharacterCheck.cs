using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CharacterCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Character Check:
            Console.WriteLine("Enter any alphabet to check if it is vowel or consonant");
            char alpha = Convert.ToChar(Console.ReadLine());
            switch (alpha)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It is a vowel");
                    break;

                default:
                    Console.WriteLine("It is a consonant");
                    break;
            }
            Console.ReadLine();


        }
    }
}
