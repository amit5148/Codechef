using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.MAY12
{
    public class STONES
    {
        public static void _Main()
        {
            int cases = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < cases; ++cs)
            {
                string j = Console.ReadLine();
                string s = Console.ReadLine();

                int ret = 0;
                for (int i = 0; i < s.Length; ++i)
                    if (j.IndexOf(s[i]) > -1)
                        ret++;
                Console.WriteLine(ret);
            }

        }
    }
}
