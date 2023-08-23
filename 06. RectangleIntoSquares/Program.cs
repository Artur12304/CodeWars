using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sqInRect = new List<int> {3,5};
            List<int> solution = new List<int> { };
            while (sqInRect[0] != 0 && sqInRect[1] != 0)
            {
                if(sqInRect[0] >= sqInRect[1])
                {
                    solution.Add(sqInRect[1]);
                    sqInRect[0] -= sqInRect[1];
                }
                else
                {
                    solution.Add(sqInRect[0]);
                    sqInRect[1] -= sqInRect[0];
                }
            }
            foreach (var item in solution)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
