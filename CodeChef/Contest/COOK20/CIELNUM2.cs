using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.COOK20
{
    public class CIELNUM2
    {
        private static bool IsCeil(string s)
        {
            if (s.Contains('0') || s.Contains('1') || s.Contains('2') || s.Contains('4') || s.Contains('6') || s.Contains('7') || s.Contains('9'))
                return false;
            int ec = s.Count(ch => ch == '8'), fc = s.Count(ch => ch == '5'), tc = s.Count(ch => ch == '3');
            if (ec >= fc && fc >= tc)
                return true;
            return false;
        }

        private static string GetPi(string s)
        {
            string pi = "";
            for (int i = s.Length - 1; i >= 0; --i)
            {
                if (s[i] <= '9' && s[i] >= '0')
                    pi += s[i];
                else
                    break;
            }
            return pi;
        }

        public static void _Main()
        {
            int n = int.Parse(Console.ReadLine());
            int ret = 0;
            for (int cs = 0; cs < n; ++cs)
            {
                string input = Console.ReadLine();
                if (IsCeil(GetPi(input)))
                    ret++;
            }
            Console.WriteLine(ret);
        }
    }
}
