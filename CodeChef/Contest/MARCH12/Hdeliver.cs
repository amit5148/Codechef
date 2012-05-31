using System;
using System.Collections.Generic;
namespace CodeChef.Contest.MARCH12
{
    public class Hdeliver
    {
        public static int IntParseFastI(string value)
        {
            int result = 0;
            for (int i = 0; i < value.Length && value[i] != ' '; i++)
            {
                char letter = value[i];
                result = 10 * result + (letter - 48);
            }
            return result;
        }
        public static int IntParseFastII(string value)
        {
            int result = 0, i = 0;
            while (value[i] != ' ')
                i++;
            i++;
            for (; i < value.Length; i++)
            {
                char letter = value[i];
                result = 10 * result + (letter - 48);
            }
            return result;
        }
        public static void _Main()
        {
            int t = IntParseFastI(Console.ReadLine());
            for (int cs = 0; cs < t; ++cs)
            {
                var nm = Console.ReadLine();
                int n = IntParseFastI(nm), m = IntParseFastII(nm);
                const int defVal = -1;
                var val = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    val[i] = defVal;
                }
                var points = new List<KeyValuePair<int, int>>();
                for (int i = 0; i < m; ++i)
                {
                    var ab = Console.ReadLine();
                    int a = IntParseFastI(ab), b = IntParseFastII(ab);
                    int min = Math.Min(a, b), max = Math.Max(a, b);
                    if (min != max)
                        points.Add(new KeyValuePair<int, int>(min, max));
                }
                points.Sort((a, b) =>
                {
                    if (a.Key < b.Key)
                        return -1;
                    if (b.Key < a.Key)
                        return 1;
                    if (a.Value < b.Value)
                        return -1;
                    if (b.Value < a.Value)
                        return 1;
                    return 0;
                });
                foreach (var keyValuePair in points)
                {
                    int a = keyValuePair.Key, b = keyValuePair.Value;
                    if (val[a] == defVal && val[b] == defVal)
                    {
                        val[a] = val[b] = a;
                    }
                    else if (val[a] == defVal)
                    {
                        val[a] = val[b];
                    }
                    else if (val[b] == defVal)
                    {
                        val[b] = val[a];
                    }
                    else
                    {
                        int x = Math.Min(val[a], val[b]), y = Math.Max(val[a], val[b]);
                        if (x != y)
                        {
                            for (int j = 0; j < n; ++j)
                                if (val[j] == y)
                                    val[j] = x;
                        }
                    }
                }
                int q = IntParseFastI(Console.ReadLine());
                for (int i = 0; i < q; ++i)
                {
                    var ab = Console.ReadLine();
                    int a = IntParseFastI(ab), b = IntParseFastII(ab);
                    if (val[a] == val[b])
                        Console.WriteLine("YO");
                    else
                        Console.WriteLine("NO");
                }
            }
        }
    }
}