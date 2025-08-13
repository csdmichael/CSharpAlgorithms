public class NearByDuplicates {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        if (nums.Length <= 1) return false;
        Dictionary<int,List<int>> d = new Dictionary<int,List<int>>();
        for (int i = 0; i < nums.Length; i++) {
            int curr = nums[i];
            if (d.ContainsKey(curr)) {
                List<int> lst = d[curr];
                for (int ctr = 0; ctr < lst.Count; ctr++) {
                    int j = lst[ctr];
                    if (Math.Abs(i-j) <= k) return true;
                }
                lst.Add(i);
            }
            else {
                List<int> lst = new List<int>();
                lst.Add(i);
                d.Add(curr, lst);
            }
        }
        return false;
    }
}
/*
1,2,3,1
K=3

Dict d
1: 0
2: 1
3: 2
*/


/*
Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

 

Example 1:

Input: nums = [1,2,3,1], k = 3
Output: true
Example 2:

Input: nums = [1,0,1,1], k = 1
Output: true
Example 3:

Input: nums = [1,2,3,1,2,3], k = 2
Output: false
 

Constraints:

1 <= nums.length <= 105
-109 <= nums[i] <= 109
0 <= k <= 105
*/