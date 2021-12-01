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
            int n = 2004;
            int solution = 0;
            string answer = "";
            for (int i = 0; i < roman.Length; i++)
            {
                if (roman.Length > i + 1 && letter.IndexOf(roman[i]) > letter.IndexOf(roman[i + 1]))
                {
                    solution += (number[letter.IndexOf(roman[i + 1])] - number[letter.IndexOf(roman[i])]);
                    i++;
                }
                else
                {
                    solution += number[letter.IndexOf(roman[i])];
                }
            }
            Console.WriteLine(solution);

            for (int i = 0; n > 0;)
            {
                if (n >= number[i])
                {
                    n -= number[i];
                    answer += letter[i];
                }
                else if ((i % 2 == 0 && n >= (number[i] - number[i + 2])) || (i % 2 != 0 && n >= (number[i] - number[i + 1])))
                {
                    if(i%2 == 0)
                    {
                        n -= (number[i] - number[i + 2]);
                        answer += $"{letter[i + 2]}{letter[i]}";
                    }
                    else
                    {
                        n -= (number[i] - number[i + 1]);
                        answer += $"{letter[i + 1]}{letter[i]}";
                    }
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
