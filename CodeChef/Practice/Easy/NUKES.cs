using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Practice.Easy
{
    public class NUKES
    {
        public static void Main()
        {
            string[] ank = Console.ReadLine().Split(' ');
            int a = int.Parse(ank[0]), n = int.Parse(ank[1]), k = int.Parse(ank[2]);
            int b = n + 1;
            List<int> r = new List<int>();

            if (b > 1)
                while (a > 0)
                {
                    r.Add(a % b);
                    a /= b;
                }

            //r.Reverse();

            while (r.Count < k)
                r.Add(0);

            for (int i = 0; i < k - 1; ++i)
                Console.Write("{0} ", r[i]);
            Console.WriteLine(r[k - 1]);
        }
    }
}
