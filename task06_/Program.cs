using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "икосаэдр";
            var word1 = s
                .Remove(5)
                .Remove(2, 2)
                .Remove(0, 1);
            word1 += s.Substring(6);

            Console.WriteLine(word1);
            Console.ReadKey();
        }
    }
}
