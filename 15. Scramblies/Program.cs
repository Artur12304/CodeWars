using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "cedewaraaossoqqyt", str2 = "codewars";
            Console.WriteLine(str2.All(x => str1.Count(y => y == x) >= str2.Count(y => y == x)));
            Console.ReadKey();
        }
    }
}
