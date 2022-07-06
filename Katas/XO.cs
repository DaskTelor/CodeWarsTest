using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest.Katas
{
    internal static class KataXO
    {
        public static int retInt(this TestClass a) => a.digit;
        public static bool XO(string input)
        {
            return input.ToLower().Where(x => x == 'x').Count() == input.ToLower().Where(x => x == 'o').Count();
        }
    }
}
