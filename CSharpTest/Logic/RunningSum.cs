public class RunningSum {
    public int GetSubArraysSumEqK(int[] arr, int k) {
        if (arr == null) return 0;
        else if (arr.Length == 0) return 0;
        else {
            int res = 0;
            for (int i = 0; i < arr.Length; i++) {
                
                int index = i;
                int runningSum = 0;
                while (runningSum < k && index < arr.Length) {
                    runningSum += arr[index];
                    if (runningSum == k) {
                        res++;
                        break;
                    } else {
                        index++;
                    }
                }
                
            }
            return res;
        }
    }
}