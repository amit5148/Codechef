using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.COOK20
{
    public class CEILNUM1
    {
        static public string NextLexiPermutation(string str)
        {
            char[] s = str.ToArray();
            int i = -1, j = 0;

            for (int x = s.Length - 2; x >= 0; x--)
                if (s[x] < s[x + 1])
                {
                    i = x;
                    break;
                }

            if (-1 == i)
                return null;

            for (int x = s.Length - 1; x > i; x--)
                if (s[x] > s[i])
                {
                    j = x;
                    break;
                }

            char temp = s[i];
            s[i] = s[j];
            s[j] = temp;

            Array.Reverse(s, i + 1, s.Length - (i + 1));
            return new string(s);
        }

        private static readonly List<string> CeilNumbers = new List<string>();

        private static void GenerateCeils(int e, int f, int t)
        {
            string ceil = new string('3', t) + new string('5', f) + new string('8', e);
            CeilNumbers.Add(ceil);
            while (true)
            {
                ceil = NextLexiPermutation(ceil);
                if (string.IsNullOrEmpty(ceil))
                    break;
                CeilNumbers.Add(ceil);
            }
            Console.WriteLine("{0} {1} {2}", e, f, t);
        }

        public static void _Main()
        {
            int numbersGenerated = 0, numbersDisplayed = 0;

            int d = 1;
            for (int e = 1; ; ++e)
                for (int f = 0; f <= e; ++f)
                    for (int t = 0; t <= f; ++t)
                    {
                        if (e >= f && f >= t && e + f + t == d)
                        {
                            GenerateCeils(e, f, t);
                            if (e == d)
                            {
                                d++;
                                e = f = t = 0;

                                numbersGenerated += CeilNumbers.Count;

                                CeilNumbers.Sort((a, b) =>
                                {
                                    if (a.Length < b.Length)
                                        return -1;
                                    if (a.Length > b.Length)
                                        return 1;
                                    return string.Compare(a, b);
                                });

                                for (int i = 0; i < CeilNumbers.Count && numbersDisplayed < 400; ++i)
                                {
                                    //Console.WriteLine(CeilNumbers[i]);
                                    numbersDisplayed++;
                                }

                                CeilNumbers.Clear();

                                if (numbersGenerated >= 400)
                                    return;
                                //e = f = t = -2;
                            }

                        }
                    }
        }

    }
}