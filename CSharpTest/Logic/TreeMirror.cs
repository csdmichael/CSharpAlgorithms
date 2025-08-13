public class TreeMirror {
    public bool IsTreeMirror(TreeNode root1, TreeNode root2) {
        if (root1 == null && root2 == null) {
            return true;
        } else if (root1 == null || root2 == null) {
            return false;
        } else {
            bool res1 = (root1.val == root2.val)? true : false;
            bool res2 = IsTreeMirror(root1.left, root2.right);
            bool res3 = IsTreeMirror(root1.right, root2.left);

            return res1 && res2 && res3;
        }
    }
}

