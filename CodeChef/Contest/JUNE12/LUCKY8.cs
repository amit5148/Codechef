using System;

namespace CodeChef.Contest.JUNE12
{
    public class LUCKY8
    {
        public static int Solve(int n)
        {
            int maxP = 0;
            for (int i = 1; i < n; ++i)
            {
                int cp = i * (n - i);
                if (cp > maxP)
                    maxP = cp;
            }
            return maxP;
        }

        public static int Solve(long a, long b)
        {
            string astr = a.ToString(), bstr = b.ToString();

            var diffIndex = 0;
            for (int i = 0; i < astr.Length && astr[i] == bstr[i]; ++i, ++diffIndex) { }

            if (diffIndex == astr.Length)
            {
                int fourCount = 0, sevenCount = 0;
                foreach (char t in astr)
                {
                    if (t == '4')
                        fourCount++;
                    else if (t == '7')
                        sevenCount++;
                }
                return fourCount * sevenCount;
            }
            if (diffIndex >= astr.Length - 2)
            {
                int maxP = 0;
                for (long i = a; i <= b; ++i)
                {
                    var str = i.ToString();
                    int fourCount = 0, sevenCount = 0;
                    foreach (char t in str)
                    {
                        if (t == '4')
                            fourCount++;
                        else if (t == '7')
                            sevenCount++;
                    }
                    if (fourCount * sevenCount > maxP)
                        maxP = fourCount * sevenCount;
                }
                return maxP;
            }

            int start = int.Parse(astr.Substring(diffIndex, 2)), end = int.Parse(bstr.Substring(diffIndex, 2));
            int pendingDigits = astr.Length - diffIndex - 2;

            int givenFours = 0, givenSevens = 0;
            for (int i = 0; i < diffIndex; ++i)
                if (astr[i] == '4')
                    givenFours++;
                else if (astr[i] == '7')
                    givenSevens++;

            int maxPr = 0;
            for (int num = start; num <= end; ++num)
            {
                int fc = givenFours, sc = givenSevens;
                string numString = num.ToString();
                foreach (char c in numString)
                {
                    if (c == '4')
                        fc++;
                    else if (c == '7')
                        sc++;
                }

                for (int cnt = 0; cnt < pendingDigits; ++cnt)
                {
                    if (fc <= sc)
                        fc++;
                    else
                        sc++;
                }
                if (fc * sc > maxPr)
                    maxPr = fc * sc;
            }

            return maxPr;
        }

        public static void Main()
        {
            int totalCases = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < totalCases; ++cs)
            {
                string[] lr = Console.ReadLine().Split(' ');
                long l = long.Parse(lr[0]), r = long.Parse(lr[1]);

                int llength = l.ToString().Length, rlength = r.ToString().Length;

                int ret = 0;
                for (int length = llength; length <= rlength; ++length)
                {
                    if (length == llength && length == rlength)
                        ret = Math.Max(ret, Solve(l, r));
                    else if (length == llength)
                    {
                        long re = (long)Math.Pow(10, length) - 1;
                        ret = Math.Max(ret, Solve(l, re));
                    }
                    else if (length == rlength)
                    {
                        long le = (long)Math.Pow(10, length - 1);
                        ret = Math.Max(ret, Solve(le, r));
                    }
                    else
                    {
                        ret = Math.Max(ret, Solve(length));
                    }
                }
                Console.WriteLine(ret);
            }
        }
    }
}
