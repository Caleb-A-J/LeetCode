using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MergeSort
    {
        public static void Sort(int[] array)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            Sort(left);
            Sort(right);
            Merge(array, left, right);
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {

        }
}
