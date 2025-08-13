public class QuickSortAlgo {
    public int[] sort(int[] arr) {
        if (arr == null) return arr;
        else if (arr.Length <= 1) return arr;
        else {
            sortHelper(ref arr, 0, arr.Length -1);
            return arr;
        }
    }

    public void sortHelper(ref int[] arr, int start, int end) { 
        if (start >= end) return;
        int pivot = pickPivot(start, end);
        for (int i = start; i <= end; i++) {
            if (
             (arr[i] > arr[pivot] && i < pivot)||
             (arr[i] < arr[pivot] && i > pivot)
            ) {
                int temp = arr[i];
                arr[i] = arr[pivot];
                arr[pivot] = temp;
                pivot = i;
            }
        }
        sortHelper(ref arr, start, pivot - 1);
        sortHelper(ref arr, pivot + 1, end);
    }

    private int pickPivot(int start, int end) {
        return (start + end) / 2;
    }
}