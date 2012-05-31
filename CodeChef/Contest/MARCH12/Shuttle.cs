using System;
using System.Collections.Generic;
using System.IO;

namespace CodeChef.Contest.MARCH12
{
    public class Shuttle
    {
        public static int Solve(int number)
        {
            List<int> factors = new List<int>();
            int max = number / 2;

            if (number % 2 == 0)
            {
                factors.Add(1);
                number /= 2;
            }
            while (number % 2 == 0)
            {
                factors.Add(2);
                number /= 2;
            }

            if (number % 3 == 0)
            {
                factors.Add(2);
                number /= 3;
            }
            while (number % 3 == 0)
            {
                factors.Add(3);
                number /= 3;
            }

            for (int i = 5; i <= max; i += 2)
            {
                if (number % i == 0)
                {
                    factors.Add(i - 1);
                    number /= i;
                }
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                }
            }

            if (factors.Count == 0)
                factors.Add(number - 1);

            int ans = 1;

            foreach (var factor in factors)
            {
                ans *= factor;
            }

            return ans;
        }

        public static void _Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(Solve(n));
            }

        }
    }
}
