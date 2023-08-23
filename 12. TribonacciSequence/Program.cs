using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] signature = { 1, 1, 1 };
            int n = 11;
            for (int i = 3; i < n; i++)
            {
                signature = signature.Concat(new double[] { signature[i - 3] + signature[i - 2] + signature[i - 1] }).ToArray();
            }
            Console.WriteLine(String.Join(",", signature.Take(n).ToArray()));
            Console.ReadKey();
        }
    }
}
