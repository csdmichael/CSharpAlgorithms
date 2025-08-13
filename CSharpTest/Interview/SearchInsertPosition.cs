public class SearchInsertPosition {
    public int SearchInsert(int[] nums, int target) {
        return SearchInsertHelper(nums, target, 0, nums.Length - 1);
    }

    private int SearchInsertHelper(int[] nums, int target, int start, int end) {
        if (start == end) {
            if (target == nums[start]) return start;
            else if (target > nums[start]) return start + 1;
            else {
                int res = start - 1;
                if (res == -1) res = 0;
                return res;
            }
        }
        int middle = (start + end) / 2;
        int midNum = nums[middle];
        if (target == nums[middle]) return middle;
        else if (target > nums[middle]) {
            return SearchInsertHelper(nums, target, middle + 1, end);
        } else {
            return SearchInsertHelper(nums, target, start, middle - 1);
        }
    }
}

/*
Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [1,3,5,6], target = 5
Output: 2
Example 2:

Input: nums = [1,3,5,6], target = 2
Output: 1
Example 3:

Input: nums = [1,3,5,6], target = 7
Output: 4
 

Constraints:

1 <= nums.length <= 104
-104 <= nums[i] <= 104
nums contains distinct values sorted in ascending order.
-104 <= target <= 104
*/