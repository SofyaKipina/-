using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите переменную:");
            var x = double.Parse(Console.ReadLine());
            var y = MyFunction(x);
            Console.WriteLine("f(x)=" + y);
            Console.ReadKey();
        }
        static double MyFunction(double x)
    {
     //throw new NotImplementedException();
            return 1 + Math.Sqrt((x * x - 1)/(1 + x * x));
    }
    }
}
