using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Practice.Easy
{
    public class MARCHA1
    {
        public static void _Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < t; ++cs)
            {
                string[] nm = Console.ReadLine().Split(' ');
                int n = int.Parse(nm[0]), m = int.Parse(nm[1]);
                List<int> notes = new List<int>();
                for (int i = 0; i < n; ++i)
                    notes.Add(int.Parse(Console.ReadLine()));

                int target = 1 << n;
                bool solutionFound = false;
                for (int mask = 0; mask < target; ++mask)
                {
                    int sum = 0;
                    for (int j = 0; j < n; ++j)
                    {
                        if ((mask & (1 << j)) > 0)
                        {
                            sum += notes[j];
                        }
                    }
                    if (sum == m)
                    {
                        solutionFound = true;
                        break;
                    }
                }

                Console.WriteLine(solutionFound ? "Yes" : "No");

            }
        }
    }
}
