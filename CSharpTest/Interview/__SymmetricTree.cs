public class SymmetricTree {
    public bool IsSymmetric(TreeNode root) {
        if (root == null) return true;
        return IsSymmetricHelper(root.left, root.right);
    }

    private bool IsSymmetricHelper(TreeNode root1, TreeNode root2) {
        if (root1 == null && root2 == null) return true;
        else if (root1 == null || root2 == null) return false;
        else if (root1.val != root2.val) return false;
        else {
            bool s1 = IsSymmetricHelper(root1.left, root2.right);           
            bool s2 = IsSymmetricHelper(root1.right, root2.left);
            return s1 && s2;
        }
    }
}

/*
Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center).

 

Example 1:


Input: root = [1,2,2,3,4,4,3]
Output: true
Example 2:


Input: root = [1,2,2,null,3,null,3]
Output: false
 

Constraints:

The number of nodes in the tree is in the range [1, 1000].
-100 <= Node.val <= 100
*/