using System;

namespace CodeChef.Contest.JUNE12
{
    public class RESQ
    {
        public static void _Main()
        {
            int totalCases = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < totalCases; ++cs)
            {
                int n = int.Parse(Console.ReadLine());
                int mind = n;
                for (int i = 1; i * i <= n; ++i)
                {
                    int j = n / i;
                    if (i * j == n && (j - i) < mind)
                        mind = j - i;
                }
                Console.WriteLine(mind);
            }
        }
    }
}
