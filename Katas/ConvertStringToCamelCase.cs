using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTest.Katas
{
    internal class ConvertStringToCamelCase
    {
        public static string ToCamelCase(string str)
        {
            string[] words = str.Split('_', '-');

            for (int i = 1; i < words.Length; i++)
                words[i] = string.Concat(words[i].Substring(0, 1).ToUpper(), words[i].Substring(1).ToLower());

            return string.Concat(words);
        }
    }
}
