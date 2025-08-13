using System.Collections.Generic;
using System.Linq;

public class MinAbsDiffBST {
    private SortedDictionary<int, bool> s;
    private List<int> data;
    public int GetMinimumDifference(TreeNode root) {
        data = new List<int>();
        s = new SortedDictionary<int, bool>();
        TraverseInOrder(root);
        return s.Keys.ElementAt(0);
    }

    private void TraverseInOrder(TreeNode root) {
        //Process Left
        if (root.left != null) {
            TraverseInOrder(root.left);
        }

        //Process Root
        data.Add(root.val);
        int dataLen = data.Count;
        if (dataLen > 1) {
            int diff = data[dataLen - 1] - data[dataLen - 2];
            if (!s.ContainsKey(diff)) {
                s.Add(diff, true);
            }
        }

        //Process Right
        if (root.right != null) {
            TraverseInOrder(root.right);
        }
    }
}

/*
Given the root of a Binary Search Tree (BST), return the minimum absolute difference between the values of any two different nodes in the tree.

 

Example 1:


Input: root = [4,2,6,1,3]
Output: 1
Example 2:


Input: root = [1,0,48,null,null,12,49]
Output: 1
 

Constraints:

The number of nodes in the tree is in the range [2, 104].
0 <= Node.val <= 105
*/