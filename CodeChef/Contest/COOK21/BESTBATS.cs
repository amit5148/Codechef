using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.COOK21
{
    public class BESTBATS
    {
        private static Dictionary<KeyValuePair<int, int>, long> cache = new Dictionary<KeyValuePair<int, int>, long>();

        public static long Combinations(int n, int r)
        {
            if (n == r)
                return 1;
            if (r == 1)
                return n;
            if (n == 1)
                return 1;
            KeyValuePair<int, int> kvp = new KeyValuePair<int, int>(n, r);

            if (cache.ContainsKey(kvp) == false)
            {
                cache[kvp] = Combinations(n - 1, r - 1) + Combinations(n - 1, r);
            }

            return cache[kvp];
        }

        public static void _Main()
        {
            //for (int n = 1; n < 12; ++n)
            //    for (int r = 1; r < n; ++r)
            //        Console.WriteLine("{0},{1} - {2}", n, r, Combinations(n, r));

            int n = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < n; ++cs)
            {
                string[] inputParts = Console.ReadLine().Split(' ');

                List<int> s = new List<int>();

                for (int i = 0; i < inputParts.Length; ++i)
                {
                    s.Add(int.Parse(inputParts[i]));
                }
                s.Sort();

                int k = int.Parse(Console.ReadLine());

                int p = s[s.Count - k];
                int total = 0;

                for (int i = 0; i < s.Count; ++i)
                    if (s[i] == p)
                        total++;

                int wanted = 0;
                for (int i = s.Count - k; i < s.Count; ++i)
                    if (s[i] == p)
                        wanted++;

                Console.WriteLine(Combinations(total, wanted));
            }

        }
    }
}
