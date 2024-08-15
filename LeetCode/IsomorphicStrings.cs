using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class IsomorphicStrings
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, char> charMap = new Dictionary<char, char>();

            // will iterate throught the strings simultaneously 
            for (int i = 0; i < s.Length; i++)
            {
                char sChar = s[i];
                char tChar = t[i];

                if (charMap.ContainsKey(sChar))
                {
                    //if the char from s is already in the dictionary, and char from t is diff
                    if (charMap[sChar] != tChar)     
                    {
                        return false;
                    }
                }
                else
                {
                    // and if the char from t is already stored, return false 
                    if (charMap.ContainsValue(tChar))
                    {
                        return false;
                    }
                    charMap.Add(sChar, tChar);
                }
            }
            return true;
        }
    }
}
