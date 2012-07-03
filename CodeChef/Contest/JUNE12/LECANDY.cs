using System;

namespace CodeChef.Contest.JUNE12
{
    public class LECANDY
    {
        public static void _Main()
        {
            int totalCases = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < totalCases; ++cs)
            {
                int c = int.Parse(Console.ReadLine().Split(' ')[1]);
                string[] nums = Console.ReadLine().Split(' ');
                int sum = 0;
                for (int i = 0; i < nums.Length; ++i)
                    sum += int.Parse(nums[i]);
                Console.WriteLine(sum <= c ? "Yes" : "No");
            }
        }
    }
}
