using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.APRIL12
{
    public class Playfit
    {
        public static void _Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int a = 0; a < t; ++a)
            {
                int n = int.Parse(Console.ReadLine());
                var goals = Console.ReadLine().Split(' ').Select(g => int.Parse(g)).ToList();

                int maxGoals = 0;

                int max = -1, min = 10000000;

                for (int i = goals.Count - 1; i >= 0; --i)
                {
                    if (goals[i] > max)
                    {
                        min = max = goals[i];
                    }
                    else if (goals[i] < min)
                    {
                        min = goals[i];
                        maxGoals = Math.Max(maxGoals, max - min);
                    }
                }

                if (maxGoals > 0)
                    Console.WriteLine(maxGoals);
                else
                    Console.WriteLine("UNFIT");
            }
        }
    }
}
