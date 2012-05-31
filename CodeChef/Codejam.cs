using System;
using System.Linq;

namespace CodeJam
{
    class EvenRoute
    {
        string IsItPossible(int[] x, int[] y, int wantedParity)
        {
            long count = 0;
            int currentXpos = 0;
            int currentYpos = 0;
            for (int i = 0; i < x.Count(); i++)
            {
                count = count + System.Math.Abs(currentXpos - x[i]) + System.Math.Abs(currentYpos - y[i]);
                currentXpos = x[i];
                currentYpos = y[i];
            }
            bool flag = count % 2 == 0;
            flag = wantedParity == 0 ? (flag) : (!flag);
            count = 0;
            currentXpos = 0;
            currentYpos = 0;
            if (!flag)
            {
                for (int i = x.Count(); i > 0; i--)
                {
                    count = count + System.Math.Abs(currentXpos - x[i - 1]) + System.Math.Abs(currentYpos - y[i - 1]);
                    currentXpos = x[i - 1];
                    currentYpos = y[i - 1];
                }
                flag = count % 2 == 0;
                flag = wantedParity == 0 ? (flag) : (!flag);
            }
            //flag = wantedParity == 0 ? (flag) : (!flag);
            return flag ? "CAN" : "CANNOT";
        }

        #region Testing code Do not change
        public static void _Main(String[] args)
        {
            EvenRoute evenRoute = new EvenRoute();
            String input = Console.ReadLine();
            do
            {
                var inputParts = input.Split('|');
                var x = inputParts[0].Split(',').ToList().Select(int.Parse).ToArray();
                var y = inputParts[1].Split(',').ToList().Select(int.Parse).ToArray();
                int wantedParity = int.Parse(inputParts[2]);
                Console.WriteLine(evenRoute.IsItPossible(x, y, wantedParity));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}