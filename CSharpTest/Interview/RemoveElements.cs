public class RemoveElement {
    public int RemoveElementVal(int[] nums, int val) {
       int p1 = nums.Length - 1, p2 = p1;
       while (p2 >= 0 && p1 >= 0) {
           if (nums[p1] == val) {
               p1--;
               p2 = p1;
           } else {
               if (nums[p2] == val) {
                   int temp = nums[p2];
                   nums[p2] = nums[p1];
                   nums[p1] = temp;
               } else {
                   p2--;
               }
           }
       } 
       return p1+1;
    }
}

/*
3,2,2,3 -> 2,2,3,3   val=3
p1 (find non-val) = 3 -> 2 -> 1 
p2 (find val) = 1 -> 0
swap(nums[p1], nums[p2])
return p1 + 1;
*/