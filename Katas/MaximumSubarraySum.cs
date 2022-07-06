using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest.Katas
{
    internal class MaximumSubarraySum
    {
        private struct Range
        {
            public int index;
            public int length;
            public int sign;
        }
        public static int MaxSequence(int[] arr)
        {
            int counter = 1;
            int lastSign = Math.Abs(arr[0]) / arr[0];
            var b = arr.GroupBy(x => 
            {
                int currentSign = Math.Abs(x) / x;
                return new { Count = (lastSign == currentSign? ++counter : counter = 1), Sign = currentSign };
            }).Select(x => 
            {
                return new Range() { index = 1, length = 2, sign = 1};
            });
            Console.WriteLine(string.Join("\n", b.Select(v => String.Join(" ", v))));//

            return 12345;
        }
    }
}
