using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = 1, b = 100;
            double sol;
            List<long> numbers = new List<long>();
            while (a < b)
            {
                var c = a.ToString().ToCharArray();
                sol = 0;
                for (int i = 0; i < c.Length; i++)
                {
                    sol += Math.Pow((int)Char.GetNumericValue(c[i]), (i+1));
                }
                if(sol == a)
                {
                    numbers.Add((long)sol);
                }
                a++;
            }
            Console.WriteLine(String.Join(", ", numbers));
            Console.ReadKey();
        }
    }
}
