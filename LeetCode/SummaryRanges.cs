using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SummaryRange
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();

            if (nums.Length == 0)
            {
                // Empty input array, return an empty list
                return result;
            }

            int start = nums[0]; // Initialize the start of the current range
            int end = nums[0]; // Initialize the end of the current range

            for (int i = 1; i < nums.Length; i++)
            {
                // Check if the current number is consecutive to the previous number
                if (nums[i] == end + 1)
                {
                    // If consecutive, update the end of the current range
                    end = nums[i];
                }
                else
                {
                    // If not consecutive, add the current range to the result list
                    result.Add(start == end ? start.ToString() : $"{start}->{end}");

                    // Start a new range
                    start = nums[i];
                    end = nums[i];
                }
            }

            // Add the last range to the result list
            result.Add(start == end ? start.ToString() : $"{start}->{end}");

            return result;
        }
    }
}
