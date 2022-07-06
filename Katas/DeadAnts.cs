using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest.Katas
{
    internal class DeadAnts
    {
        public static int DeadAntCount(string ants)
        {
            if (ants == null)
                return 0;
            string ant = "ant";
            ants = ants.Replace(ant, "");
            int max = 0, temp;

            foreach (char i in ant)
                if ((temp = ants.Select(x => x).Where(x => x == i).Count()) > max)
                    max = temp;

            return max;

            return ants == null ? 0 : "ant".Select(c => ants.Replace("ant", "").Count(l => l == c)).Max();//жеское решение
        }
    }
}
