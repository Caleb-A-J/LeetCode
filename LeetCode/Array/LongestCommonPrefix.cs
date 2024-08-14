using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class LongestCommonPrefix
    {
        public string LongestPrefix(string[] strs)
        {
            // will check for empty input array 
            if (strs == null || strs.Length == 0)
                return "";
            // use the first string 
            string prefix = strs[0];

            // Iterate through the remaining strings
            for (int i = 1; i < strs.Length; i++)
            {        
                // While the current prefix is not a substring at the beginning of the current string
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);

                    // If the prefix becomes empty
                    if (prefix == "")
                        return "";
                }
            }
            return prefix;
        }
    }
}
