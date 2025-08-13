public class KLargest {
    public int FindKthLargest(int[] nums, int k) {
        int maxIndex = -1;
        Dictionary<int,int> maxs = new Dictionary<int,int>();
        for (int j = 1; j <= k; j++) {
            int max = -10000;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] > max && (j == 1 || !maxs.ContainsKey(i))) {
                    max = nums[i];
                    maxIndex = i;
                }
            }
            maxs.Add(maxIndex, max);
        }
        return maxs[maxIndex];
    }
}