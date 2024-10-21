using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = GetNumber("n");

            if (IfStatementTrue(n))
                Console.WriteLine("утверждение истинно");
            else Console.WriteLine("утверждение ложно");

            Console.ReadKey();
        }
        static bool IfStatementTrue(int n)
        {
            return n % 5 == 0 | n % 7 == 0;
        }
        static int GetNumber(string numberName)
        {
            Console.WriteLine($"введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }
    }
}
