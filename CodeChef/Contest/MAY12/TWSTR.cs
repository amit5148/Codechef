using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.MAY12
{
    public class TWSTR
    {
        private static SortedList<int, string> _recipes;

        private static int GetStartingIndex(string query)
        {
            return 0;
        }

        public static void _Main()
        {
            int n = int.Parse(Console.ReadLine());

            //List<string> recipes = new List<string>();
            //List<int> priorities = new List<int>();

            _recipes = new SortedList<int, string>();

            for (int i = 0; i < n; ++i)
            {
                string[] input = Console.ReadLine().Split(' ');

                _recipes.Add(int.Parse(input[1]), input[0]);
            }

            int q = int.Parse(Console.ReadLine());

            for (int i = 0; i < q; ++i)
            {
                string query = Console.ReadLine();
                bool found = false;
                for (int j = n - 1; j >= 0; --j)
                {
                    var key = _recipes.Keys[j];
                    if (_recipes[key].StartsWith(query))
                    {
                        found = true;
                        Console.WriteLine(_recipes[key]);
                        break;
                    }
                }
                if (!found)
                    Console.WriteLine("NO");
            }

        }
    }
}
