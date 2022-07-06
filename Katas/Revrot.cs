using System;
using System.Linq;
using System.Text;

public class Revrot
{
    private static bool Check(string str)
    {
        int sum = 0;
        foreach (var i in str)
            sum += ((int)i - '0') * ((int)i - '0');
        return sum % 2 == 0;   
    }
    public static string RevRot(string strng, int sz)
    {
        StringBuilder chanks = new StringBuilder();
        for (int i = 0; i + sz < strng.Length && sz != 0; i += sz)
        {
            
            string temp;
            
            if (Check(temp = strng.Substring(i, sz)))
                chanks.Append(new string(temp.Reverse().ToArray()));
            else
                chanks.Append(temp.Substring(1, temp.Length - 1) + temp[0]);
            
        }
        return chanks.ToString();
    }
}