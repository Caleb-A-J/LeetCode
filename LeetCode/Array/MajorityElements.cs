using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Solutionnn
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int stored = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    stored = num;
                }
                count += (num == stored) ? 1 : -1;
            }

            // Verify if stored is the majority element
            count = 0;
            foreach (int num in nums)
            {
                if (num == stored)
                {
                    count++;
                }
            }

            return count > nums.Length / 2 ? stored : -1; // Return -1 if no majority element
        }
    }
}

