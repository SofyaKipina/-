using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите внешний диаметр кольца:");
            double diametr1 = double.Parse(Console.ReadLine());
            Console.WriteLine("введите внутренний диаметр кольца:");
            double diametr2 = double.Parse(Console.ReadLine());

            double S = (diametr1 - diametr2) * Math.PI;
         
            Console.WriteLine("S кольца=" + Math.Round(S, 3));
            
            Console.ReadKey();
        }
    }
}
