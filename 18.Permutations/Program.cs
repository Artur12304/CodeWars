using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(",", SinglePermutations("abc")));
            Console.ReadKey();
        }
        private static List<string> SinglePermutations(string s)
        {
            var output = new List<string>();
            if (s.Length == 1)
            {
                output.Add(s);
            }
            else
            {
                foreach (var c in s.Distinct())
                {
                    var tail = s.Remove(s.IndexOf(c), 1);
                    foreach (var tailPerms in SinglePermutations(tail).Distinct())
                    {
                        output.Add(c + tailPerms);
                    }
                }
            }
            return output;
        }
    }
}
