using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integers = { 160, 3, 1719, 19, 11, 13, -21 };
            Console.WriteLine(integers.Count(x => x % 2 != 0) == 1 ? integers.Where(x => x % 2 != 0).Sum() : integers.Where(x => x % 2 == 0).Sum());
            Console.ReadKey();
        }
    }
}
