public class TwoSum {
    public int[] GetTwoSum(int[] nums, int target) {
        Dictionary<int, int> d = new Dictionary<int,int>();
        int[] res = new int[2];

        for (int i = 0; i < nums.Length; i++) {
            int curr = nums[i];
            int f = target - curr;
            if (d.ContainsKey(f)) {
                res[0] = d[f];
                res[1] = i;
            }
            else {
                if (!d.ContainsKey(curr)) {
                    d.Add(curr, i);
                }
                
            }
        }
        return res;
    }
}

/*
2,7,11,15
t=9

f=2

Hash
2  0

*/