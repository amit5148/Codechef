using System;

namespace CodeChef.Contest.MAY12
{
    public class DIVPAIR
    {
        public static void _Main()
        {
            int totalCases = int.Parse(Console.ReadLine());

            for (int caseNo = 1; caseNo <= totalCases; ++caseNo)
            {
                //string[] nm = Console.ReadLine().Split(' ');
                //int n = int.Parse(nm[0]);
                //int m = int.Parse(nm[1]);

                Console.WriteLine(SolveUsingMyFormula(1000000000, 2));

                //for (int n = 1000000000 - 100; n <= 1000000000; ++n)
                //    for (int m = 1000000000 - 100; m <= 1000000000; ++m)
                //    {
                //        int calculatedAnswer = SolveUsingMyFormula(n, m);

                //        int actualAnswer = SolveUsingBruteForce(n, m);

                //        if (calculatedAnswer != actualAnswer)
                //        {
                //            Console.WriteLine("Failed for ({0},{1})  {2}  {3}", n, m, calculatedAnswer, actualAnswer);
                //        }
                //        else
                //        {
                //            //Console.WriteLine("Passed for ({0},{1})", n, m);
                //        }
                //    }
            }

        }

        public static long SolveUsingMyFormula(long n, long m)
        {
            long x = (2 * n / m);
            long y = (n / m);

            long extra = m % 2 == 0 ? x : x / 2;

            long totalPoints1 = (((((x * (x + 1) / 2) * (m)) - x) - extra) / 2);

            long totalPoints2 = (m * (x * (x + 1) / 2) - m * (y * (y + 1) / 2) - (x - y) * n - (x - y));

            return totalPoints1 - totalPoints2;
        }

        public static int SolveUsingBruteForce(int n, int m)
        {
            int ret = 0;

            for (int i = 1; i <= n; ++i)
                for (int j = i + 1; j <= n; ++j)
                {
                    if ((i + j) % m == 0)
                        ret++;
                }

            return ret;
        }

    }
}
