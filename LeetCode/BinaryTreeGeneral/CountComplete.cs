using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Intervals
{
    public class CountComplete
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public class Solution
        {
            public int CountNodes(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                int leftHeight = 0, rightHeight = 0;

                // Find the height of the left and right subtrees
                TreeNode left = root, right = root;
                while (left != null)
                {
                    leftHeight++;
                    left = left.left;
                }
                while (right != null)
                {
                    rightHeight++;
                    right = right.right;
                }

                // If the heights are equal the tree is full and we can calculate the number of nodes
                if (leftHeight == rightHeight)
                {
                    return (int)Math.Pow(2, leftHeight) - 1;
                }

                // Otherwise the tree is not full and we need to recursively count nodes in both subtrees
                return CountNodes(root.left) + CountNodes(root.right) + 1;
            }
        }
    }
}
