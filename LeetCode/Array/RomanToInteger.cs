using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            var romanToInteger = new Dictionary<char, int>
            {

                //assigning the values 
                ['I'] = 1,
                ['V'] = 5,
                ['X'] = 10,
                ['L'] = 50,
                ['C'] = 100,
                ['D'] = 500,
                ['M'] = 1000
            };

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                // stores integer value of the current RN 
                int current = romanToInteger[s[i]];
                //sees if there is another char in the string
                int next = (i + 1 < s.Length) ? romanToInteger[s[i + 1]] : 0;
                //if there is another char and the current RN is less than the next, it will do the subtraction case 
                if (current < next)
                {
                    result -= current;
                }
                else
                {
                    result += current;
                }
            }
            return result;  
        }
    }
}
