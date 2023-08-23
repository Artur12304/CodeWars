using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "k123rishan";
            var b = str.Where(x => char.IsLetter(x)).Reverse();
            Console.WriteLine(String.Join("", b));
            Console.ReadKey();
        }
    }
}
