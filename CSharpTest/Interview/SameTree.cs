public class SameTree {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null) return true;
        else if (p == null || q == null) return false;
        else {
            if (p.val != q.val) return false;
            bool b1 = IsSameTree(p.left, q.left);
            bool b2 = IsSameTree(p.right, q.right);
            return b1 && b2;
        }
    }
}