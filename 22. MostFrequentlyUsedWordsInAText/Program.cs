using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "e e e e DDD ddd DdD: ddd ddd aa aA Aa, bb cc cC e e e";
            var b = s.ToLower()
                .Split(' ', '#', '\\', '/', '.', ',', ':', ';', '!', '-', '?', '_')
                .GroupBy(x => x)
                .Select(x => new KeyValuePair<string, int>(x.Key, x.Count()))
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .Where(x => x.Any(x => Char.IsLetter(x)))
                .Take(3)
                .ToList();
            Console.WriteLine(String.Join(" ", b));

            //var b = Regex.Matches(s.ToLowerInvariant(), @"('*[a-z]'*)+")
            //.GroupBy(match => match.Value)
            //.OrderByDescending(g => g.Count())
            //.Select(p => p.Key)
            //.Take(3)
            //.ToList();
            //Console.WriteLine(String.Join(" ", b));

            Console.ReadKey();
        }
    }
}
