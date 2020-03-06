using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //5var
            double res;
            Random r = new Random();
            double a = r.Next();
            Console.WriteLine("First number: " + (a));
            Random r1 = new Random();
            double b = r1.Next();
            Console.WriteLine("Second number: " + (b));
            Console.WriteLine("Result =" + (res = task1(a, b)));
            Console.ReadLine();
        }
        static double task1(double x, double y)
        {
            double result = x - y;
            return result;
        }

    }
}
