using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class AverageLevel
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x)
            { val = x; }
        }
        public IList<double> AverageOfLevels(TreeNode root)
        {
            if (root == null)
            {
                // if the tree is empty return an empty list
                return new List<double>();
            }

            var result = new List<double>(); // store the average for each floor
            var queue = new Queue<TreeNode>(); // a line of people waiting to be measured
            queue.Enqueue(root); // put the first person (root) in line

            while (queue.Count > 0)
            {
                int count = queue.Count; // how many people are on this floor
                double sum = 0; // the total height of everyone on this floor

                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue(); // get the next person in line
                    sum += node.val; // add their height to the total

                    // Put their children in line for the next floor
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }

                // calculate the average height for this floor and store it
                result.Add(sum / count);
            }

            return result;
        }
    }
}
