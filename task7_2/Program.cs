using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки через пробел:");
            var input = Console.ReadLine();

            var index = input.IndexOf(" "); //ищем индекс пробела в строке
            var x = double.Parse(input.Substring(0, index));
            var y = double.Parse(input.Substring(index + 1));

            Console.WriteLine($"Введена точка ({x};{y})");

            if (IsPointInArea(x, y))
                Console.WriteLine($"Точка ({x};{y}) лежит в указанной области");
            else
                Console.WriteLine($"Точка ({x};{y}) не лежит в указанной области");

            Console.ReadKey();
        }
        static bool IsPointInArea(double x, double y)
        {
            return y >= 0 && x >= 2 || x >= 1 && y <= -1;
        }
    }
}
