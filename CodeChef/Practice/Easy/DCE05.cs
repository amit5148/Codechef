using System;

namespace CodeChef.Practice.Easy
{
    public class DCE05
    {
        public static void _Main()
        {
            var totalCases = int.Parse(Console.ReadLine());

            for (int cs = 1; cs <= totalCases; ++cs)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine((int)Math.Pow(2, (int)Math.Log(n, 2)));
            }
        }
    }
}
