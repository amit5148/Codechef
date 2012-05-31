using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.MAY12
{
    public class CHEFHOME
    {
        public static void _Main()
        {
            int totalCases = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < totalCases; ++cs)
            {
                int n = int.Parse(Console.ReadLine());

                if (n % 2 == 1)
                {
                    for (int i = 0; i < n; ++i)
                        Console.ReadLine();
                    Console.WriteLine("1");
                }
                else
                {
                    List<long> x = new List<long>();
                    List<long> y = new List<long>();

                    for (int i = 0; i < n; ++i)
                    {
                        var xy = Console.ReadLine().Split(' ');
                        x.Add(long.Parse(xy[0]));
                        y.Add(long.Parse(xy[1]));
                    }

                    x.Sort();
                    y.Sort();
                    Console.WriteLine((x[n / 2] - x[n / 2 - 1] + 1) * (y[n / 2] - y[n / 2 - 1] + 1));
                }
            }

        }

    }
}
