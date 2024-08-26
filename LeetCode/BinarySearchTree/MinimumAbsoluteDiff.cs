using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearchTree
{
    public class MinimumAbsoluteDiff
    {
        public class Solution
        { }
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
        
            public int MinDiffInBST(TreeNode root)
            {
                int minDiff = int.MaxValue;
                int prevVal = int.MinValue;

                Stack<TreeNode> stack = new Stack<TreeNode>();
                TreeNode curr = root;

                while (curr != null || stack.Count > 0)
                {
                    while (curr != null)
                    {
                        stack.Push(curr);
                        curr = curr.left;
                    }

                    curr = stack.Pop();


                    int diff = Math.Abs(curr.val - prevVal);
                    minDiff = Math.Min(minDiff, diff);
                    prevVal = curr.val;

                    curr = curr.right;
                }

                return minDiff;
            }
        
    }
}
