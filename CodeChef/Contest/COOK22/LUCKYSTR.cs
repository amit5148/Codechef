using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.COOK22
{
    public class LUCKYSTR
    {
        public static void _Main()
        {
            string[] kn = Console.ReadLine().Split(' ');
            int k = int.Parse(kn[0]);
            int n = int.Parse(kn[1]);

            List<string> l = new List<string>();
            for (int i = 0; i < k; ++i)
            {
                l.Add(Console.ReadLine());
            }

            for (int i = 0; i < n; ++i)
            {
                string s = Console.ReadLine();
                if (s.Length >= 47)
                    Console.WriteLine("Good");
                else
                {
                    int j = 0;
                    for (; j < l.Count; ++j)
                    {
                        if (s.IndexOf(l[j]) >= 0)
                        {
                            Console.WriteLine("Good");
                            break;
                        }
                    }
                    if (j == l.Count)
                        Console.WriteLine("Bad");
                }
            }


        }
    }
}
