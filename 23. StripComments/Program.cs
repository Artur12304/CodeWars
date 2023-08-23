using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "apples, pears # and bananas\ngrapes\nbananas !apples";
            var commentSymbols = new string[] { "#", "!" };
            commentSymbols.ToList().ForEach(x => text = text.Replace(x, "#"));
            var a = text.Split("\n").Select(x => x.Contains("#") ? x.Remove(x.IndexOf("#")).TrimEnd() : x.TrimEnd());
            Console.WriteLine(String.Join("\n", a));
            Console.ReadKey();
        }
    }
}
