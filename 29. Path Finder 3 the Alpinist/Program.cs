namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = "010\n" +
                   "101\n" +
                   "010";

            Console.WriteLine("Your Path: " + PathFinder(path));
        }

        static readonly int[] dx = { -1, 0, 1, 0 };
        static readonly int[] dy = { 0, 1, 0, -1 };

        public static int PathFinder(string maze)
        {
            string[] rows = maze.Split('\n');
            int n = rows.Length;
            int m = rows[0].Length;

            int[,] heights = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    heights[i, j] = rows[i][j] - '0';
                }
            }

            Comparison<(int, int, int)> comparison = (a, b) => a.Item3.CompareTo(b.Item3);
            PriorityQueue<(int, int, int)> priorityQueue = new PriorityQueue<(int, int, int)>(comparison);
            priorityQueue.Enqueue((0, 0, 0));

            int[,] dist = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dist[i, j] = int.MaxValue;
                }
            }
            dist[0, 0] = 0;

            while (priorityQueue.Count > 0)
            {
                (int x, int y, int rounds) = priorityQueue.Dequeue();

                if (x == n - 1 && y == m - 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write(heights[i, j]);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            Console.Write(dist[i, j]);
                        }
                        Console.WriteLine();
                    }
                    return rounds;
                }

                for (int k = 0; k < 4; k++)
                {
                    int nx = x + dx[k];
                    int ny = y + dy[k];

                    if (nx >= 0 && nx < n && ny >= 0 && ny < m)
                    {
                        int climbRounds = Math.Max(0, Math.Abs(heights[nx, ny] - heights[x, y]));
                        if (dist[x, y] + climbRounds < dist[nx, ny])
                        {
                            dist[nx, ny] = dist[x, y] + climbRounds;
                            priorityQueue.Enqueue((nx, ny, dist[nx, ny]));
                        }
                    }
                }
            }

            Console.WriteLine();
            return -1;

        }
    }

    class PriorityQueue<T>
    {
        private List<T> heap = new List<T>();
        private Comparison<T> comparison;

        public int Count { get { return heap.Count; } }

        public PriorityQueue(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }

        public void Enqueue(T item)
        {
            heap.Add(item);
            int i = heap.Count - 1;
            while (i > 0)
            {
                int parent = (i - 1) / 2;
                if (comparison(heap[parent], heap[i]) <= 0) break;
                Swap(parent, i);
                i = parent;
            }
        }

        public T Dequeue()
        {
            T ret = heap[0];
            int lastIndex = heap.Count - 1;
            heap[0] = heap[lastIndex];
            heap.RemoveAt(lastIndex);

            int i = 0;
            while (true)
            {
                int left = i * 2 + 1;
                int right = i * 2 + 2;
                int smallest = i;

                if (left < heap.Count && comparison(heap[left], heap[smallest]) < 0)
                {
                    smallest = left;
                }
                if (right < heap.Count && comparison(heap[right], heap[smallest]) < 0)
                {
                    smallest = right;
                }
                if (smallest == i) break;

                Swap(i, smallest);
                i = smallest;
            }

            return ret;
        }

        private void Swap(int a, int b)
        {
            T tmp = heap[a];
            heap[a] = heap[b];
            heap[b] = tmp;
        }
    }
}
