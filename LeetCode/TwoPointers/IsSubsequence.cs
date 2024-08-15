using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Subsequence
    {
        public bool IsSubsequence(string s, string t)
        {
            int i = 0;
            int j = 0;

            while (i < s.Length)
            {
                j = t.IndexOf(s[i], j);

                // if Char from s was not found in t, if not found it will return false
                if (j == -1)
                {
                    return false;
                }
                j++;
                i++;
            }

            return true;
        }
    }
}
