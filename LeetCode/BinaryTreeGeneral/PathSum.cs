using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class PathSum
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;

            }
        }

        public class Solution
        {
            public bool HasPathSum(TreeNode root, int targetSum)
            {
                // If the root is null, there's no path, so return false
                if (root == null)
                {
                    return false;
                }

                //If the root is a leaf node, check if its value equals the remaining target sum
                if (root.left == null && root.right == null)
                {
                    return targetSum == root.val;
                }

                // Recursively check the left and right subtrees

                // Check if there's a path sum in the left subtree
                bool leftPathExists = HasPathSum(root.left, targetSum - root.val);

                // Check if there's a path sum in the right subtree
                bool rightPathExists = HasPathSum(root.right, targetSum - root.val);

                // Return true if either the left or right subtree has a path sum
                return leftPathExists || rightPathExists;
            }
        }
    }
}
