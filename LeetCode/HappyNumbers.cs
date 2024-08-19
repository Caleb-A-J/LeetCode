using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class HappyNumbers
    {
        static bool IsHappyNumber(int n)
        {
            HashSet<int> seenNumbers = new HashSet<int>();

            while (n != 1)
            {
                int sum = 0;
                while (n > 0)
                {
                    int digit = n % 10;
                    sum += (int)Math.Pow(digit, 2);
                    n /= 10;
                }

                if (seenNumbers.Contains(sum))
                {
                    return false; // Found a loop
                }

                seenNumbers.Add(sum);
                n = sum;
            }

            return true;
        }
    }
}
