public class MajorityElement {
    public int GetShiftedStrsGroupsMajorityElement(int[] nums) {
        int maj = (nums.Length / 2) + 1;
        Dictionary<int,int> d = new Dictionary<int,int>();
        for (int i = 0; i < nums.Length; i++) {
            int curr = nums[i];
            if (d.ContainsKey(curr)) {
                d[curr]++;
            } else {
                d.Add(curr,1);
            }
            if (d[curr] >= maj) return curr;
        }
        return -1;
    }
}