using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LengthOfLastWordd
    {
        public int LengthOfLastWord(string s)
        {
            s = s.Trim();
            string[] words = s.Split(' ');

            if (words.Length == 0)
            {
                return 0;
            }
            return words[words.Length - 1].Length;
        }
    }
}
