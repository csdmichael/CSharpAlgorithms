public class TreeCountNode {
    public int CountNodes(TreeNode root) {
        if (root == null) return 0;
        int count = 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while (q.Count > 0) {
            int qLen = q.Count;
            for (int i = 0; i < qLen; i++) {
                TreeNode curr = q.Dequeue();
                count++;
                if (curr.left != null) {
                    q.Enqueue(curr.left);
                }
                if (curr.right != null) {
                    q.Enqueue(curr.right);
                }
            }
        }
        return count;
    }
}