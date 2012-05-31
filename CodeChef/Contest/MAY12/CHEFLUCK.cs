using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.MAY12
{
    public class CHEFLUCK
    {
        public static void _Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                int n = int.Parse(Console.ReadLine());

                int ret = -1;

                for (int y = 0; y <= n / 7; ++y)
                {
                    if (((n - 4 * y) % 7) == 0)
                    {
                        ret = (n - 4 * y) / 7;
                        break;
                    }
                }

                if (ret > 0)
                {
                    Console.WriteLine(7 * ret);
                }
                else if (n % 4 == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("-1");
                }
            }

        }
    }
}
