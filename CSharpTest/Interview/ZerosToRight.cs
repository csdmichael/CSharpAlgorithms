public class ZerosToRight{
    public void MoveZeroes(int[] nums) {
        if (nums == null) return;
        if (nums.Length <= 1) return;
        int p1 = nums.Length - 1;
        int p2 = p1;
        while (p1 >= 0 && p2 >= 0) {
            if (nums[p1] == 0) {
                p1--;
                p2--;
            }
            else {
                if (nums[p2] != 0) {
                    p2--;
                }
                else {
                    for (int i = p2; i < p1; i++) {
                        nums[i] = nums[i+1];
                    } 
                    nums[p1] = 0;
                    p1--;
                    p2--;
                }
            }
        }
    }
}