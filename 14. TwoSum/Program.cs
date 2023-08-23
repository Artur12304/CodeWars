using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            int target = 4;
            Console.WriteLine(String.Join(",", TwoSum(numbers, target)));
            Console.ReadKey();
        }
        public static int[] TwoSum(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
                for (int j = 0; j < numbers.Length; j++)
                    if (i != j)
                        if (numbers[i] + numbers[j] == target)
                            return new int[] { i, j };
            return new int[0];
        }
    }
}
