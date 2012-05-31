using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Practice.Easy
{
    public class RESN04
    {
        public static void _Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int cs = 0; cs < t; ++cs)
            {
                int n = int.Parse(Console.ReadLine());
                string[] nums = Console.ReadLine().Split(' ');
                List<int> stones = new List<int>();
                for (int i = 0; i < n; ++i)
                    stones.Add(int.Parse(nums[i]));

                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    count = count + stones[i] / (i + 1);
                }

                if (count % 2 == 0)
                    Console.WriteLine("BOB");
                else
                    Console.WriteLine("ALICE");
            }
        }
    }
}
