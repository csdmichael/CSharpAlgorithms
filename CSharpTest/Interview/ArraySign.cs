public class ArraySign {
    public int GetArraySign(int[] nums) {
        int product;
        if (nums.Length == 1) {product = nums[0];}
        else {
            product = ArraySignCalc(nums);
        }

        if (product == 0) return 0;
        else if (product < 0) return -1;
        else return 1;
    }

    public int ArraySignCalc(int[] nums) {
        int prod = 1; 
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] < 0) {
                prod *= -1;
            } else if (nums[i] == 0) {
                prod = 0;
                break;
            }
        }
        return prod;
    }

    public long ArraySignHelper(int[] nums, int start, int end) { 
        if (end <= start) {
            return nums[start];
        }
        else {
            int middle = (start + end) / 2;
            long res = ArraySignHelper(nums, start, middle) * ArraySignHelper(nums, middle + 1, end);
            return res;
        }
    }


}