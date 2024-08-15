using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RansomNote
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            // Create a dictionary to store the frequency of characters in the magazine
            Dictionary<char, int> magazineCharCount = new Dictionary<char, int>();
            foreach (char c in magazine)
            {
                if (magazineCharCount.ContainsKey(c))
                {
                    //if the char has been encounted before, it is incremented
                    magazineCharCount[c]++;
                }
                else
                {
                    // if the char is not in the dictionary, it will be added 
                    magazineCharCount[c] = 1;
                }
            }

            // Check if each character in the ransom note can be found in the magazine
            foreach (char c in ransomNote)
            {
                if (!magazineCharCount.ContainsKey(c) || magazineCharCount[c] == 0)
                {
                    // if the char is not in the magazine then it will return false 
                    //if the char is found but its count is 0, then the char is already used up
                    return false;
                }
                //if both conditions were false, the char will be decremented
                magazineCharCount[c]--;
            }

            return true;
        }
    }
}
