public class ArrayAnomaly {
    
    private int FindFirstAnomaly_Helper(int[] arr, int left, int right) {
        if (right - left == 0) {
            int anomaly;
            int diff = arr[right] - arr[right-1];
            if (diff == 1) {
                anomaly = -1;
            } else {
                anomaly = right - 1;
            }
            return anomaly;
        } else {
            int anomalyB = -1, anomalyC = -1;
            int middle = (left + right) / 2;
            anomalyB = FindFirstAnomaly_Helper(arr, left, middle);
            if (anomalyB == -1) {
                anomalyC = FindFirstAnomaly_Helper(arr, middle + 1, right);
                return anomalyC;
            }
            else {
                return anomalyB;
            }
        }
    }
    public int FindFirstAnomaly(int[] arr) {
        if (arr == null) {
            return -1;
        } else if (arr.Length < 2) {
            return -1;
        } else {
            return FindFirstAnomaly_Helper(arr, 1, arr.Length - 1);
        }
    }
}