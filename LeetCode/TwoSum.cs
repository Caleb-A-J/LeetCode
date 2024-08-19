using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solutionnnnn
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numIndices = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // calc the complement/value needed to add up to the target
                int complement = target - nums[i];

                //check if the complement is already in the dictionary 
                if (numIndices.ContainsKey(complement))
                {
                    //if found, return the indices
                    return new int[] { numIndices[complement], i };
                }
                // if not found, add the element and its index to the dict
                numIndices[nums[i]] = i;
            }

            // If no solution is found,return an empty array or throw an exception
            return new int[] { };
        }
    }
}
