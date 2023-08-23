namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", Seven(372)));
        }
        public static long[] Seven(long m)
        {
            int count = 0;
            while (m.ToString().Length > 2)
            {
                m = m / 10 - (m % 10 * 2);
                count++;
            }

            return new long[] { m, count };
        }
    }
}
