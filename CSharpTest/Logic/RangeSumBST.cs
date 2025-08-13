public class RangeSumBST {
    public int GetRangeSumBST(int lower, int higher, TreeNode root) {
        if (root == null) {
            return 0;
        } else {
            int rangeSum = 0;
            //Do BFS traverse    
            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root);

            while (q.Count > 0) {
                int qLen = q.Count;
                for (int i = 0; i < qLen; i++) {
                    TreeNode node = q.Dequeue();
                    if (node.val >= lower && node.val <= higher) {
                        rangeSum += node.val;
                    }
                    if (node.left != null) {
                        q.Enqueue(node.left);
                    }
                    
                    if (node.right != null) {
                        q.Enqueue(node.right);
                    }
                }
            }
            return rangeSum;
        }

    }
}