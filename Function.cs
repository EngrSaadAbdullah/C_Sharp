using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            add(100, 25);
            Console.ReadLine();

            sub(100, 25);
            Console.ReadLine();

            mult(10, 25);
            Console.ReadLine();

            div(200, 25);
            Console.ReadLine();

            square(2);
            Console.ReadLine();

            cube(2);
            Console.ReadLine();

            avg(100, 50);
            Console.ReadLine();

        }
        static void add(int a,int b)
        {
            int cc = a + b;
            Console.WriteLine(cc);
        }

        static void sub(int c,int d)
        { 
            Console.WriteLine(c-d); 
        }

        static void mult(int e, int f)
        {
            Console.WriteLine(e*f);
        }

        static void div(int g, int h)
        {
            Console.WriteLine(g/h);
        }

        static void square(int i)
        {
            Console.WriteLine(i*i);
        }

        static void cube(int j)
        {
            Console.WriteLine(j*j*j);
        }

        static void avg(double k, double l)
        {
            double m = (k+l)/200;
            Console.WriteLine(m*100);
        }
    }
}
