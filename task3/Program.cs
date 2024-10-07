using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите трехзначное число:");
            int a=int.Parse(Console.ReadLine());
            int b = a / 100;
            int c = a % 10;
            int d = a / 10 % 10;
            Console.WriteLine(b * 100 + c * 10 + d);
            Console.ReadKey();
        }
    }
}
