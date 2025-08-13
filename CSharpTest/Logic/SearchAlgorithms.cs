public class SearchAlgorithms {
    public int BinarySearchHelper(int[] sortedArray, int left, int right, int x) {
        if (right >= left) {
            int middle = (left + right) / 2;
            if (sortedArray[middle] == x) 
                return middle;
            else if (sortedArray[middle] > x) { // Search Left half
                right = middle - 1;
                BinarySearchHelper(sortedArray, left, right, x);
            } 
            else if (sortedArray[middle] < x) { // Search Right half
                left = middle + 1;
                BinarySearchHelper(sortedArray, left, right, x);
            } 
            return -1;
        } else {
            return -1;
        }
    }

    public int BinarySearch(int[] array, int x) {
        if (array == null) {
            return -1;
        } else if (array.Length == 0) {
            return -1;
        } else if (array.Length == 1) {
            if (array[0] == x) {
                return 0;
            } else {
                return -1;
            }
        } else {
            //Sort array
            int[] sortedArray = SortArray(array);
            return BinarySearchHelper(sortedArray, 0, sortedArray.Length - 1, x);
        }
    }

    public int[] SortArray(int[] array) {
        return array;
    }
}

