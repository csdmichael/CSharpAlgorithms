public class ArrayAnomalyE {
    public int FindFirstAnomaly(int[] arr) {
        if (arr == null) return -1;
        if (arr.Length <= 1) return -1;
        return FindAnomalyHelper(arr, 1, arr.Length - 1);
    }

    private int FindAnomalyHelper(int[] arr, int start, int end) {
        if (start == end) {
            int diff = arr[start] - arr[start - 1];
            if (diff == 1) return -1;
            else return start;
        }
        int middle = (start + end) / 2;
        int res1 = FindAnomalyHelper(arr, start, middle);
        if (res1 != -1) return res1;
        else {
            return FindAnomalyHelper(arr, middle + 1, end);
        } 
    }
}

/*
[3,4,5,6,8,9,11]
N = 7

m = 7/2 = 3
res = fa(arr, 0, 3)
if res <> -1 return res
else res2 = fa(arr, 4, 6)
return res2

O(log N)
*/