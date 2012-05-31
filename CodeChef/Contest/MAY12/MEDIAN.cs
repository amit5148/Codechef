using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.MAY12
{
    public class MEDIAN
    {
        public static int Solve(List<int> num)
        {
            int n = num.Count;
            num.Sort();

            int alr = num.Count(t => t == num[n - 1]);

            int ans = 0;
            while (alr < n)
            {
                alr *= 2;
                ans++;
            }

            //int ans = (int)Math.Ceiling(Math.Log(n - alr, 2));

            if (num[0] == num[n - 1])
            {
                return 0;
            }
            if (n == 2)
            {
                return 1;
            }
            int target = num[n - 1];
            int ptr = n / 2;

            int steps = 1;
            while (num[ptr] != target)
            {
                ptr = (n + ptr) / 2;
                steps++;
            }

            if (ans != steps)
            {
                Console.WriteLine("----------------------------");
            }

            return steps;
        }

        public static void _Main()
        {
            int totalCases = int.Parse(Console.ReadLine());

            for (int t = 0; t < totalCases; ++t)
            {
                List<int> num = new List<int>();

                var rg = new Random();

                for (int i = 0; i < 30; ++i)
                {
                    num.Add(rg.Next(1, 1000000000));
                }

                Solve(num);
            }

            //for (int cs = 0; cs < totalCases; ++cs)
            //{
            //    int n = int.Parse(Console.ReadLine());

            //    var nums = Console.ReadLine().Split(' ');

            //    List<int> num = new List<int>();
            //    for (int i = 0; i < n; ++i)
            //        num.Add(int.Parse(nums[i]));

            //    Console.WriteLine(Solve(num));

            //}
        }
    }
}
