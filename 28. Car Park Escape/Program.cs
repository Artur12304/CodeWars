namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var parking = new int[,] { { 1, 0, 0 },
                                          { 0, 0, 1 },
                                          { 2, 0, 1 },
                                          { 0, 0, 0 } };

            Console.WriteLine("Your Path: " + String.Join(", ", Escape(parking)));
        }

        public static string[] Escape(int[,] carpark)
        {
            var pos = -2;
            var stairs = -1;
            var levels = 0;
            var result = new List<string>();

            for (int i = 0; i < carpark.GetLength(0); i++)
            {
                for (int j = 0; j < carpark.GetLength(1); j++)
                {
                    if (carpark[i, j] == 2)
                    {
                        pos = j;
                    }
                    if (carpark[i, j] == 1)
                    {
                        stairs = j;
                    }
                }
                if (pos == stairs)
                {
                    levels++;
                }
                else
                {
                    if (pos >= 0)
                    {
                        if (levels > 0)
                        {
                            result.Add($"D{levels}");
                            levels = 0;
                        }

                        if (stairs == -1)
                        {
                            if (carpark.GetLength(1) - pos - 1 > 0)
                            {
                                result.Add($"R{carpark.GetLength(1) - pos - 1}");
                            }
                            break;
                        }
                        result.Add(stairs - pos < 0 ? $"L{-(stairs - pos)}" : $"R{(stairs - pos)}");
                        pos = stairs;
                        levels++;
                    }
                }

                stairs = -1;
            }
            return result.ToArray();
        }
    }
}
