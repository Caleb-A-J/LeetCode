using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class SymetricTree
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

        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        public bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            if (left == null || right == null)
            {
                return false;
            }
            return left.val == right.val && IsMirror(left.left, right.right) && IsMirror(left.right, right.left);
        }
    }
}
