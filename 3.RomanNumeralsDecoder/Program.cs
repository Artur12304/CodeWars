using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int> { 1000, 500, 100, 50, 10, 5, 1 };
            List<char> letter = new List<char> { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };
            string roman = "MMVIII";
            int solution = 0;
            for (int i = 0; i < roman.Length; i++)
            {
                if(roman.Length > i + 1 && letter.IndexOf(roman[i]) > letter.IndexOf(roman[i + 1]))
                {
                    solution += (number[letter.IndexOf(roman[i+1])] - number[letter.IndexOf(roman[i])]);
                    i++;
                }
                else
                {
                    solution += number[letter.IndexOf(roman[i])];
                }
            }
            Console.WriteLine(solution);
            Console.ReadKey();
        }
    }
}
