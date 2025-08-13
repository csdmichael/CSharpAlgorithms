public class TreeMaxLevelSum {
    public int MaxLevelSum(TreeNode root) {
        if (root == null) return 0;
        int level = 0;
        int maxLevel = 1;
        int max = root.val;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0) {
            int qLen = q.Count;
            int sum = 0;
            level++;
            for (int i = 0; i < qLen; i++) {
                TreeNode curr = q.Dequeue();
                sum += curr.val;
                if (curr.left != null) {
                    q.Enqueue(curr.left);
                }
                if (curr.right != null) {
                    q.Enqueue(curr.right);
                }
            }
            if (sum > max) {
                max = sum;
                maxLevel = level;
            }
        }
        return maxLevel;
    }
}
/*
Given the root of a binary tree, the level of its root is 1, the level of its children is 2, and so on.

Return the smallest level x such that the sum of all the values of nodes at level x is maximal.

 

Example 1:


Input: root = [1,7,0,7,-8,null,null]
Output: 2
Explanation: 
Level 1 sum = 1.
Level 2 sum = 7 + 0 = 7.
Level 3 sum = 7 + -8 = -1.
So we return the level with the maximum sum which is level 2.
Example 2:

Input: root = [989,null,10250,98693,-89388,null,null,null,-32127]
Output: 2
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
-105 <= Node.val <= 105
*/