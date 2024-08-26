using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array
{
    public class RemoveDuplicatesll
    {
        public int RemoveDuplicates(int[] nums)
        {
            int count = 1;
            int toFillIn = 1;
            for (int i = 1; i < nums.Length; i++) // go through each item
            {
                if (nums[i - 1] == nums[i])
                {
                    count++;
                }
                else
                {
                    count = 1;

                }
                if (count <= 2)// this i should be replaced by the next value
                    nums[toFillIn++] = nums[i];
            }
            return toFillIn;
        }
    }
}
