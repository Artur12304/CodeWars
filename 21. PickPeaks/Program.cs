using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var getPeaks = new Dictionary<string, List<int>>();
            getPeaks.Add("pos", new List<int>());
            getPeaks.Add("peaks", new List<int>());
            var arr = new int[] { -2, 2, 2, 7, 2, 19, -5, -3, 17, 11, 3 };
            int pos = 0, peak = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1])
                {
                    pos = i;
                    peak = arr[i];
                }
                if (pos != 0 && arr[i] > arr[i + 1])
                {
                    getPeaks["pos"].Add(pos);
                    getPeaks["peaks"].Add(peak);
                    pos = 0;
                    peak = 0;
                }
            }
            foreach (KeyValuePair<string, List<int>> item in getPeaks)
            {
                Console.WriteLine($"{item.Key}, {String.Join(",", item.Value)}");
            }
            Console.ReadKey();
        }
    }
}
