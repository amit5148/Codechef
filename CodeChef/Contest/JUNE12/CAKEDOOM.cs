using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.JUNE12
{
    public class CAKEDOOM
    {
        public static int K;

        public static string SolveOne(string cake)
        {
            if (cake[0] == '?')
                return "0";
            if (int.Parse(cake) < K)
                return cake;
            return "NO";
        }

        public static string SolveTwo(string cake)
        {
            if (K == 1)
                return "NO";
            if (cake == "??")
            {
                return "01";
            }
            if (cake[0] == '?')
            {
                if (cake[1] == '0')
                    return "10";
                return "0" + cake[1];
            }
            if (cake[1] == '?')
            {
                if (cake[0] == '0')
                    return "01";
                return cake[0] + "0";
            }
            int a = int.Parse(cake[0].ToString());
            int b = int.Parse(cake[1].ToString());
            if (a < K && b < K && a != b)
                return cake;
            return "NO";
        }

        public static string SolveGeneric(string cake)
        {
            int l = cake.Length;
            if (l == 1)
                return SolveOne(cake);
            if (l == 2)
                return SolveTwo(cake);

            StringBuilder sb = new StringBuilder(cake);

            char first = sb[0], last = sb[l - 1];

            if (first != '?' && first == last)
                return "NO";

            StringBuilder sb1 = new StringBuilder(cake), sb2 = new StringBuilder(cake), sb3 = new StringBuilder(cake);

            int firstPlace = cake.IndexOf('?');
            if (firstPlace > -1)
            {
                sb1[firstPlace] = '0';
                sb2[firstPlace] = '1';
                sb3[firstPlace] = '2';
            }

            for (int currentIndex = 0; currentIndex < cake.Length; ++currentIndex)
            {
                int previousIndex = (currentIndex + l - 1) % l, nextIndex = (currentIndex + l + 1) % l;

                char previous = sb1[previousIndex], current = sb1[currentIndex], next = sb1[nextIndex];

                if (current == '?')
                {
                    char ch = GetMin(previous, next);
                    if (ch == '*')
                    {
                        sb1 = new StringBuilder();
                        break;
                    }
                    sb1[currentIndex] = ch;
                }
                else
                {
                    if (current == previous || current == next || int.Parse(current.ToString()) >= K)
                    {
                        sb1 = new StringBuilder();
                        break;
                    }
                }
            }

            for (int currentIndex = 0; currentIndex < cake.Length; ++currentIndex)
            {
                int previousIndex = (currentIndex + l - 1) % l, nextIndex = (currentIndex + l + 1) % l;

                char previous = sb2[previousIndex], current = sb2[currentIndex], next = sb2[nextIndex];

                if (current == '?')
                {
                    char ch = GetMin(previous, next);
                    if (ch == '*')
                    {
                        sb2 = new StringBuilder();
                        break;
                    }
                    sb2[currentIndex] = ch;
                }
                else
                {
                    if (current == previous || current == next || int.Parse(current.ToString()) >= K)
                    {
                        sb2 = new StringBuilder();
                        break;
                    }
                }
            }

            for (int currentIndex = 0; currentIndex < cake.Length; ++currentIndex)
            {
                int previousIndex = (currentIndex + l - 1) % l, nextIndex = (currentIndex + l + 1) % l;

                char previous = sb3[previousIndex], current = sb3[currentIndex], next = sb3[nextIndex];

                if (current == '?')
                {
                    char ch = GetMin(previous, next);
                    if (ch == '*')
                    {
                        sb3 = new StringBuilder();
                        break;
                    }
                    sb3[currentIndex] = ch;
                }
                else
                {
                    if (current == previous || current == next || int.Parse(current.ToString()) >= K)
                    {
                        sb3 = new StringBuilder();
                        break;
                    }
                }
            }

            string a = sb1.ToString(), b = sb2.ToString(), c = sb3.ToString();

            if (a.Length > 0 && (b.Length == 0 || string.Compare(a, b) <= 0) && (c.Length == 0 || string.Compare(a, c) <= 0))
                return a;
            if (b.Length > 0 && (a.Length == 0 || string.Compare(b, a) <= 0) && (c.Length == 0 || string.Compare(b, c) <= 0))
                return b;
            if (c.Length > 0 && (a.Length == 0 || string.Compare(c, a) <= 0) && (b.Length == 0 || string.Compare(c, b) <= 0))
                return c;
            return "NO";
        }

        public static char GetMin(char p, char n)
        {
            char ch = '0';
            for (int i = 0; i < K; ++i, ++ch)
            {
                if (p != ch && n != ch)
                    return ch;
            }
            return '*';
        }

        public static char GetFinalMin(char p, char n)
        {
            char ch = '0';
            for (int i = 0; i < K; ++i, ++ch)
            {
                if (p != ch && n != ch)
                    return ch;
            }
            return '*';
        }

        public static void _Main()
        {
            int totalCases = int.Parse(Console.ReadLine());

            for (int cs = 0; cs < totalCases; ++cs)
            {
                K = int.Parse(Console.ReadLine());
                string cake = Console.ReadLine();
                Console.WriteLine(SolveGeneric(cake));
            }
        }
    }
}
