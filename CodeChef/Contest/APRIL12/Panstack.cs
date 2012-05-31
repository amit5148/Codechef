using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.APRIL12
{
    public class Panstack
    {

        public static void _Main()
        {
            List<List<ulong>> x = new List<List<ulong>>();

            x.Add(new List<ulong>() { 1 });

            for (int i = 3; i <= 1000; ++i)
            {
                var prevl = x[x.Count - 1];
                var newl = new List<ulong>();
                ulong total = 0;
                for (int j = prevl.Count - 1; j >= 0; --j)
                {
                    total += prevl[j];
                    //total %= 1000000007;
                    newl.Add(total);
                }
                newl.Add(total);
                newl.Reverse();
                x.Add(newl);
            }


            int t = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < t; ++cs)
            {
                int n = int.Parse(Console.ReadLine());

                if (n == 1)
                    Console.WriteLine(1);
                else
                {
                    ulong ret = 0;
                    for (int i = 0; i < x[n - 2].Count; ++i)
                    {
                        ret += (((ulong)i + 2) * x[n - 2][i]) % 1000000007;
                    }
                    Console.WriteLine(ret);
                }

            }
        }
    }
}
