using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] road = new string[] { "Begin on Road A", "Right on Road B", "Right on Road C", "Left on Road D" };
            Array.Reverse(road);
            for (int i = road.Length - 1; i > 0; i--)
            {
                road[i] = road[i].Replace(road[i].Substring(0, road[i].IndexOf(" ")), road[i-1].Substring(0, road[i-1].IndexOf(" ")));
                if (road[i].Contains("Right"))
                {
                    road[i] = road[i].Replace(road[i].Substring(0, road[i].IndexOf(" ")), "Left");
                }
                else
                {
                    road[i] = road[i].Replace(road[i].Substring(0, road[i].IndexOf(" ")), "Right");
                }
            }
            road[0] = road[0].Replace(road[0].Substring(0, road[0].IndexOf(" ")), "Begin");

            foreach (var a in road)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();

        }
    }
}
