using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class User
    {
        public List <int> ranks = new List<int> { -8, -7, -6, -5, -4, -3, -2, -1, 1, 2, 3, 4, 5, 6, 7, 8 };
        public int rank = 7;
        public int progress = 0;

        public void incProgress(int ActivityRank)
        {
            if(ranks.Contains(ActivityRank))
            {
                var d = ranks.IndexOf(ActivityRank) - ranks.IndexOf(rank);
                if (d > 0)
                {
                    progress += 10 * d * d;
                }
                else if(d == 0)
                {
                    progress += 3;
                }
                else if(d == -1)
                {
                    progress += 1;
                }
                if (rank == 8 || (rank == 7 && progress >= 100))
                {
                    rank = 8;
                    progress = 0;
                }
                if (progress >= 100)
                {
                    if(ranks.IndexOf(rank) + (progress / 100) >= ranks.Count())
                    {
                        rank = 8;
                        progress = 0;
                    }
                    else
                    {
                        rank = ranks.ElementAt(ranks.IndexOf(rank) + (progress / 100));
                        progress = progress % 100;
                    }
                }
                Console.WriteLine($"Rank: {rank}, Progress: {progress}%");
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
