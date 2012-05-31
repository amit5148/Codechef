using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Practice.Easy
{
    public class TLG
    {
        public static void _Main()
        {
            int n = int.Parse(Console.ReadLine());

            int maxD = 0;
            int s = 0, t = 0;
            for (int i = 0; i < n; ++i)
            {
                string[] st = Console.ReadLine().Split(' ');
                s += int.Parse(st[0]);
                t += int.Parse(st[1]);
                int d = s - t;
                if (Math.Abs(d) > Math.Abs(maxD))
                {
                    maxD = d;
                }
            }

            Console.WriteLine("{0} {1}", maxD > 0 ? 1 : 2, Math.Abs(maxD));
        }
    }
}
