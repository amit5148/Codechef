using System;

namespace CodeChef.Contest.APRIL12
{
    public class Double
    {
        public static void _Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; ++i)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 1)
                    n--;
                Console.WriteLine(n);
            }
        }
    }
}
