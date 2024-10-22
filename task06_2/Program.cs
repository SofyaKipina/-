using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task06_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Дано слово "клавиатура", получить слова "тиара" и "рука".
            
            var s = "клавиатура";
            var word1 = s.Remove(7).Remove(0, 6);
            word1 += s.Remove(6,2).Remove(0, 4);

            var word2 = ReverseString(s
                .Remove(9,1)
                .Remove(0,7));
            word2 += s.Remove(3).Remove(1, 1);


            Console.WriteLine(word1);
            Console.WriteLine(word2);


            Console.ReadKey();

        }
        static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
