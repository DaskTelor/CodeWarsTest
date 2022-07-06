using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest.Katas
{
    internal class CountingDuplicates
    {
        public static int DuplicateCountV1(string str)
        {
            if (str.Length == 0)
                return 0;

            str = string.Concat(str.ToLower().OrderBy(x => x).ToArray());
            int result = 0;
            char lastSymbol = str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == lastSymbol)
                {
                    result++;
                    while (i + 1 < str.Length && str[++i] == lastSymbol) ;
                    lastSymbol = str[i];
                }
                else lastSymbol = str[i];
            }
            return result;
        }
        public static int DuplicateCount(string str) => str.ToLower().GroupBy(x => x).Count(x => x.Count() > 1);

    }
}
