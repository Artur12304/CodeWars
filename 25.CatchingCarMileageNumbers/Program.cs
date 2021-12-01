using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            var awesomePhrases = new List<int>() { 1337, 256 };
            Console.Write("Return: ");
            Console.WriteLine(IsInteresting(number, awesomePhrases) == 1 ? "2" :
                IsInteresting(number + 1, awesomePhrases) == 1 ||
                    IsInteresting(number + 2, awesomePhrases) == 1 ? "1" : "0");
            Console.ReadKey();
        }
        public static int IsInteresting(int number, List<int> awesomePhrases)
        {
            var result = number.ToString();
            if (number >= 100 &&
                ((result[0] != '0' && result.Skip(1).All(x => x == '0')) ||
                result.All(x => x == result[0]) ||
                ("1234567890".Contains(number.ToString()) || "9876543210".Contains(number.ToString())) ||
                result.All(x => x == result[(result.Length - 1) - result.ToList().IndexOf(x)]) ||
                awesomePhrases.Contains(number)))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
