using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] sudoku ={
          new int[] {5, 3, 4, 6, 7, 8, 9, 1, 2},
          new int[] {6, 7, 2, 1, 9, 5, 3, 4, 8},
          new int[] {1, 9, 8, 3, 4, 2, 5, 6, 7},
          new int[] {8, 5, 9, 7, 6, 1, 4, 2, 3},
          new int[] {4, 2, 6, 8, 5, 3, 7, 9, 1},
          new int[] {7, 1, 3, 9, 2, 4, 8, 5, 6},
          new int[] {9, 6, 1, 5, 3, 7, 2, 8, 4},
          new int[] {2, 8, 7, 4, 1, 9, 6, 3, 5},
          new int[] {3, 4, 5, 2, 8, 6, 1, 7, 9},
        };
            var b = sudoku.SelectMany(x => x).ToList();
            for (int i = 0; i < 9; i++)
            {
                if (sudoku[i].Select(x => x).Distinct().Count() < 9) Console.WriteLine("Return: Try again!");
                if (sudoku.Select(x => x[i]).Distinct().Count() < 9) Console.WriteLine("Return: Try again!");
            }
            for (int i = 0, j=0; i < 61; i+=3, j++)
            {
                if (b[i] + b[i + 1] + b[i + 2] + b[i + 9] + b[i + 10] + b[i + 11] + b[i + 18] + b[i + 19] + b[i + 20] != 45)
                {
                    Console.WriteLine("Return: Try again!");
                }
                if (j == 2)
                {
                    Console.WriteLine("Return: Try again!");
                    i += 18;
                    j = -1;
                }
            }
            Console.WriteLine("Return: Finished!");
            Console.ReadKey();
        }
    }
}
