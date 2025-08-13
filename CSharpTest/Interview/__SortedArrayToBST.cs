public class SortedArrayToBinarySearchTree {
    public TreeNode SortedArrayToBST(int[] nums) {
        TreeNode root = null;
        SortedArrayToBST_Helper(nums, 0, nums.Length - 1, ref root);
        return root;
    }

    private void SortedArrayToBST_Helper(int[] nums, int start, int end, ref TreeNode root) {
        if (start == end) {
            int curr = nums[start];
            TreeNode node = new TreeNode(curr);
            if (root == null) {
                root = node;
            }
            else {
                if (curr < root.val) {
                    root.left = node;
                }
                else {
                    root.right = node;
                }
            }
        }
        else if (start < end) {
            int middle = (start + end) / 2;
            int val = nums[middle];
            root = new TreeNode(val);
            SortedArrayToBST_Helper(nums, start, middle - 1, ref root.left);
            SortedArrayToBST_Helper(nums, middle + 1, end, ref root.right);
        }
        
    }
}