using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeChef.Contest.MARCH12
{
    public class Spoon
    {
        public static void _Main()
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; ++i)
            {
                var rc = Console.ReadLine().Split(' ');
                int r = int.Parse(rc[0]), c = int.Parse(rc[1]);

                List<string> matrix = new List<string>();

                for (int j = 0; j < r; ++j)
                {
                    matrix.Add(Console.ReadLine().ToLower());
                }

                bool found = false;

                for (int j = 0; j < r; ++j)
                {
                    if (matrix[j].IndexOf("spoon") >= 0)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    for (int j = 0; j <= r - 5; ++j)
                    {
                        for (int k = 0; k < c; ++k)
                        {
                            if (matrix[j][k] == 's' && matrix[j + 1][k] == 'p' && matrix[j + 2][k] == 'o' && matrix[j + 3][k] == 'o' && matrix[j + 4][k] == 'n')
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found)
                            break;
                    }
                }

                if (found)
                {
                    Console.WriteLine("There is a spoon!");
                }
                else
                {
                    Console.WriteLine("There is indeed no spoon!");
                }
            }

        }
    }
}
