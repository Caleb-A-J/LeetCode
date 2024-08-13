using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[count] = nums[i];
                    count++;
                }
            }
            return count;
        }

    }
}

