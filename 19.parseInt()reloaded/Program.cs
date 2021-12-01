using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        private static readonly Dictionary<string, int> numbers = new Dictionary<string, int>
                                                             {
                                                               {"zero", 0},
                                                               {"one", 1},
                                                               {"two", 2},
                                                               {"three", 3},
                                                               {"four", 4},
                                                               {"five", 5},
                                                               {"six", 6},
                                                               {"seven", 7},
                                                               {"eight", 8},
                                                               {"nine", 9},
                                                               {"ten", 10},
                                                               {"eleven", 11},
                                                               {"twelve", 12},
                                                               {"thirteen", 13},
                                                               {"fourteen", 14},
                                                               {"fifteen", 15},
                                                               {"sixteen", 16},
                                                               {"seventeen", 17},
                                                               {"eighteen", 18},
                                                               {"nineteen", 19},
                                                               {"twenty", 20},
                                                               {"thirty", 30},
                                                               {"forty", 40},
                                                               {"fifty", 50},
                                                               {"sixty", 60},
                                                               {"seventy", 70},
                                                               {"eighty", 80},
                                                               {"ninety", 90},
                                                             };
        static void Main(string[] args)
        {
            string s = "five hundred ninety four thousand nine hundred eleven";
            int result = 0;
            s = s.Replace('-', ' ').Replace(" and", "");
            if (s == "million")
            {
                Console.WriteLine("million");
                Console.ReadKey();
                return;
            }
            foreach (var item in s.Split(' '))
            {
                Console.Write(item+" ");
                if (item == "thousand")
                {
                    result *= 1000;
                }
                else if(item == "hundred")
                {
                    var a = result % 10;
                    result += a*100 - a;
                }
                else
                {
                    result += numbers[item];
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
