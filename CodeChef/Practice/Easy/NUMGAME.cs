using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Practice.Easy
{
    public class NUMGAME
    {
        public static void _Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < t; ++cs)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(n % 2 == 0 ? "ALICE" : "BOB");
            }
        }
    }
}
