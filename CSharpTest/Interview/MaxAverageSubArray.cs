public class MaxAverageSubArray{
    public double FindMaxAverage(int[] nums, int k) {
        int max = 0;

        for (int i = 0; i <= nums.Length - k; i++) {
            int sum = GetSum(nums, i, k);
            if (i == 0) max = sum;
            else if (sum > max) {
                max = sum;
            }
        }

        double res = (1.0 * max) / k;
        return res;
    }

    public int GetSum(int[] nums, int index, int k) {
        int sum = 0;
        for (int i = index; i < index + k; i++) {
            sum += nums[i];
        }
        return sum;
    }
}

/*
You are given an integer array nums consisting of n elements, and an integer k.

Find a contiguous subarray whose length is equal to k that has the maximum average value and return this value. Any answer with a calculation error less than 10-5 will be accepted.

 

Example 1:

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
Example 2:

Input: nums = [5], k = 1
Output: 5.00000
 

Constraints:

n == nums.length
1 <= k <= n <= 105
-104 <= nums[i] <= 104
*/