using System.Collections.Generic;

public class TreeLeafsSimilar {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        if (root1 == null && root2 == null) return true;
        if (root1 == null || root2 == null) return false;

        Queue<int> leafs = new Queue<int>();
        bool isSimilar = true;
        InOrderTraverse(root1, ref leafs, false, ref isSimilar);
        InOrderTraverse(root2, ref leafs, true, ref isSimilar);
        if (leafs.Count > 0) {
            isSimilar = false;
        }
        return isSimilar;
    }

    private void InOrderTraverse(TreeNode root, ref Queue<int> leafs, bool isVerify, ref bool isSimilar) {
        if (root.left != null) {
            InOrderTraverse(root.left, ref leafs, isVerify, ref isSimilar);
        }
        //Process root
        if (root.left == null && root.right == null) {
            if (!isVerify) {
                leafs.Enqueue(root.val);
            }
            else {
                if (leafs.Count > 0) {
                    int curr = leafs.Dequeue();
                    if (curr != root.val) {
                        isSimilar = false;
                        return;
                    }
                }
                else {
                    isSimilar = false;
                    return;
                }
            }
        }

        if (root.right != null) {
            InOrderTraverse(root.right, ref leafs, isVerify, ref isSimilar);
        }
    }
}