using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pin = "12345";
            bool a = pin.All(char.IsDigit) && (pin.Length==4 || pin.Length==6);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
