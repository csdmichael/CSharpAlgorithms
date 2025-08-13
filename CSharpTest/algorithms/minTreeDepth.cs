using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest.algorithms
{
    public class TreeNode
    {
        public TreeNode(int val, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public int val { get; set; }
        public TreeNode left { get; set; }
        public TreeNode right { get; set; }
    }
    public class minTreeDepth
    {
        public static int GetMinTreeDepth(TreeNode root)
        {
            int minDepth = 0;
            if (root == null)
            {
                return minDepth;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                minDepth += 1;
                int qLen = q.Count;
                for (int i = 0; i < qLen; i++)
                {
                    TreeNode curr = q.Dequeue();
                    // If leaf node return min depth
                    if (curr.left == null && curr.right == null)
                    {
                        return minDepth;
                    }
                    else
                    {
                        if (curr.left != null)
                        {
                            q.Enqueue(curr.left);
                        }

                        if (curr.right != null)
                        {
                            q.Enqueue(curr.right);
                        }
                    }
                }
            }
            return minDepth;
        }
    }
}
