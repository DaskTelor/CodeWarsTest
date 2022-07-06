using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest.Katas
{
    internal static class MultiplesOf3Or5
    {
        public static int NotFactorial(int n) => n > 0 ? n + NotFactorial(n - 1) : 0;
        public static int Solution(int value)
        {
            int[] numbers = new[] { 3, 5 };
            int result = 0;
            foreach (int i in numbers)
                result += NotFactorial((value - 1) / i) * i;

            int mult = numbers[0] * numbers[1];
            result -= NotFactorial((value - 1) / mult) * mult;

            return result;
        }
    }
}
