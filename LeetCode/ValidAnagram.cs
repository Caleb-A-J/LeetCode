using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            // ensure the lengths are the same, or they cannot be anagrams
            if (s.Length != t.Length)
            {
                return false;

            }

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach
                    (char c in s)
            {
                // checking to see if the current C is in S
                if (charCount.ContainsKey(c))
                {
                    // if it is, we go next
                    charCount[c]++;
                }
                else
                {
                    // else we add it to the dict
                    charCount[c] = 1;

                }
            }

            foreach (char c in t)
            {
                //if C is not found as a key, it means it is not present in the first string 
                //
                //if C is present but 0, all occurences of the C have been accounted for
                if (!charCount.ContainsKey(c) || charCount[c] == 0)
                {
                    return false;
                }
                //if found and >0 we have a match so we will decrement it 
                charCount[c]--;
            }

            return true;
        }
    }
}
