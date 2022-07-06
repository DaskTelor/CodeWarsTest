using System;
using System.Numerics;

namespace CodeWarsTest.Katas
{
    class LastDigit
    {
        public static int GetLastDigit(BigInteger n1, BigInteger n2)
        {
            string str = n1.ToString();
            int result = str[str.Length - 1] - '0';
            int lastNumber = result;
            if (n2 == 0)
                return 1;
            for (BigInteger i = 1; i < n2; i++)
            {
                result = result * lastNumber % 10;
                if (result == lastNumber)
                    i = n2 / i * i;
            }
            return result;
        }
    }
}
