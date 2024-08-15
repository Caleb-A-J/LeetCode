using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            // Init two pointers: left at the beginning, right at the end
            int left = 0, right = s.Length - 1;

            // Continue iterating as long as left is less than right
            while (left < right)
            {
                // Skip non-alphanumeric characters from the left
                while (left < right && !Char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                // Skip non-alphanumeric characters from the right
                while (left < right && !Char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                // Compare characters, ignoring case
                if (Char.ToLower(s[left]) != Char.ToLower(s[right]))
                {
                    // If characters don't match, it's not a palindrome
                    return false;
                }

                // Move pointers inward for the next comparison
                left++;
                right--;
            }
            return true;
        }
    }
}
