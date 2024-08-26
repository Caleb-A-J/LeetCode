using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AddBinaryy
    {
        public string AddBinary(string a, string b)
        {
            int carry = 0;
            int i = a.Length - 1, j = b.Length - 1;
            StringBuilder result = new StringBuilder();

            while (i >= 0 || j >= 0 || carry != 0)
            {
                int digitA = (i >= 0) ? int.Parse(a[i].ToString()) : 0;
                int digitB = (j >= 0) ? int.Parse(b[j].ToString()) : 0;
                int sum = digitA + digitB + carry;

                result.Insert(0, sum % 2);
                carry = sum / 2;

                i--;
                j--;
            }

            return result.ToString();
        }
    }
}
