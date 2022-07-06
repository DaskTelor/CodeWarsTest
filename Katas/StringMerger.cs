using System;

namespace CodeWarsTest.Katas
{
    public class StringMerger
    {
        public static bool isMerge(string s, string part1, string part2)
        {
            string[] parts = new string[] { part1, part2 };
            int[] indexes = new int[parts.Length];
            bool flag;
            for (int i = 0; i < s.Length; i++)
            {
                flag = false;
                for (int k = 0; k < parts.Length; k++)
                {
                    if (indexes[k] == parts[k].Length)
                        continue;
                    if (parts[k][indexes[k]] == s[i])
                    {
                        indexes[k]++;
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    return false;
            }
            for (int i = 0; i < parts.Length; i++)
            {
                if (indexes[i] != parts[i].Length)
                    return false;
            }
            return true;
        }
    }
}

