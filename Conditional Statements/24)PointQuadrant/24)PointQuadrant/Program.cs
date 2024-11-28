using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_PointQuadrant
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Identify Quadrant of point:
            Console.WriteLine("Enter the value of X and Y");
            Console.Write("X = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y = ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x>=0 && y>=0)
            {
                Console.WriteLine("POint lies in 1st Quadrant");
            }
            else if (x<0 && y>=0)
            {
                Console.WriteLine("Point lies in 2nd Quadrant");
            }
            else if (x<0 && y<0)
            {
                Console.WriteLine("Point lies in 3rd Quadrant");
            }
            else
            {
                Console.WriteLine("Point lies in 4th Quadrant");
            }
            Console.ReadLine();



        }
    }
}
