using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = MyFunction(2, 3) + MyFunction(3, 5) + MyFunction(5, 7);
            Console.WriteLine("x=" + Math.Round(y,3));
            Console.ReadKey();
        }
        static double MyFunction(double a, double b)
        {
            return Math.Pow(Math.E,-(Math.Sqrt(a + b * b)));
            // здесь формула с е
        }
    }
}
