using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.COOK22
{
    public class LUCKYBAL
    {
        private static bool IsBalanced(string s)
        {
            for (int mid = 0; mid < s.Length; ++mid)
            {
                int l4 = 0, r7 = 0;
                for (int i = 0; i < mid; ++i)
                    if (s[i] == '4')
                        l4++;
                for (int i = mid; i < s.Length; ++i)
                    if (s[i] == '7')
                        r7++;
                if (l4 == r7)
                    return true;
            }
            return false;
        }


        public static void _Main()
        {
            int tcs = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < tcs; ++cs)
            {
                string s = Console.ReadLine();

                var ret = SolveUsingFormula(s);
                Console.WriteLine(ret);
            }
        }

        private static long SolveUsingFormula(string s)
        {
            long ret = 0, pret = 0;
            for (int i = s.Length - 1; i >= 0; --i)
            {
                if (s[i] == '7')
                {
                    ret += pret;
                }
                else
                {
                    pret = s.Length - i;
                    ret += s.Length - i;
                }
            }
            return ret;
        }

        private static int SolveUsingBruteForce(string s)
        {
            int ret = 0;
            for (int i = s.Length - 1; i >= 0; --i)
            {
                int pret = ret;
                for (int j = i; j < s.Length; ++j)
                {
                    if (IsBalanced(s.Substring(i, j - i + 1)))
                    {

                        ret++;
                    }
                }
                //Console.WriteLine(s[i] + "  --  " + pret + " - " + ret);
            }
            return ret;
        }
    }
}
