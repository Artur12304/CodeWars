using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] race = { 720, 850, 70 };
            var sec = Math.Round(((decimal)race[2] / (race[1] - race[0]) * 3600));
            int[] solution = { (int)Math.Floor(sec / 3600), (int)Math.Floor((sec -= Math.Floor(sec / 3600) * 3600) / 60), (int)Math.Floor(sec -= Math.Floor(sec / 60) * 60) };
            Console.WriteLine(solution[0]+" h, "+solution[1]+" min, "+solution[2]+" s");
            Console.ReadKey();
        }
    }
}
