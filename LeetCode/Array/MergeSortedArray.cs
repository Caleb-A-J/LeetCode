namespace LeetCode
{
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int last = m + n - 1;
            int i = m - 1, j = n - 1;

            while (i >= 0 && j >= 0)
            {
                nums1[last--] = nums1[i] > nums2[j] ? nums1[i--] : nums2[j--];
            }

            while (j >= 0)
            {
                nums1[last--] = nums2[j--];
            }
        }
    }
}