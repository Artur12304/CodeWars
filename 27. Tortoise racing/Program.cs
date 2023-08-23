namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", Race(80, 100, 40)));
        }

        public static int[] Race(int v1, int v2, int g)
        {
            var t = TimeSpan.FromHours((double)g / (v2 - v1));
            return v1 >= v2 ? null : new[] { t.Hours, t.Minutes, t.Seconds };
        }
    }
}
