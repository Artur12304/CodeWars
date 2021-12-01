using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Dermatoglyphics";
            Console.WriteLine(str.ToUpper().Distinct().Count() == str.Length);
            Console.ReadLine();
        }
    }
}
