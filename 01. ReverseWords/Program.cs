using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is an example!";

            Console.WriteLine(string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray()))));
            Console.ReadKey();
        }
    }
 }

