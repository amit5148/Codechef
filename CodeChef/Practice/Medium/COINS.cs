using System;
using System.Collections.Generic;

namespace CodeChef.Practice.Medium
{
    public class COINS
    {

        private static readonly Dictionary<long, long> ExchangeRate = new Dictionary<long, long>();

        private static long Exchange(long x)
        {
            if (x <= 2)
            {
                ExchangeRate[x] = x;
            }
            if (ExchangeRate.ContainsKey(x) == false)
            {
                ExchangeRate[x] = Math.Max(x, Exchange(x / 2) + Exchange(x / 3) + Exchange(x / 4));
            }
            return ExchangeRate[x];
        }

        public static void _Main()
        {
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input) == false)
            {
                long goldCoins = long.Parse(input);
                Console.WriteLine(Exchange(goldCoins));
                input = Console.ReadLine();
            }
        }
    }
}
