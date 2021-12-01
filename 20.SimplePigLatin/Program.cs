using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Pig latin is cool !";
            var s = String.Join(" ", str.Split(" ").Select(x => x.Length > 1 ? x.Substring(1) + x.Remove(1)+"ay" : x));
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
