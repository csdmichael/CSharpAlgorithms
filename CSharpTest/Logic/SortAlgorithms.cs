using System.Collections.Generic;

public class SortAlgorithms {
    public int[] MergeSort(int[] array) {
        List<int> sortedList = new List<int>();
        if (array == null) {
            return new int[]{};
        } else {
            int length = array.Length;
            if (length <= 1) {
                return array;
            } else { 
                sortedList = MergeSortHelper(array, 0, length - 1);
                return sortedList.ToArray();
            }
        }
    }

    public List<int> MergeLists(List<int> list1, List<int> list2) {
        List<int> mergedList = new List<int>();
        int pos1 = 0; int pos2 = 0;
        while (pos1 < list1.Count || pos2 < list2.Count) {
            if (pos1 == list1.Count && pos2 < list2.Count) {
                mergedList.Add(list2[pos2]);
                pos2++;
            }
            else if (pos2 == list2.Count && pos1 < list1.Count) {
                mergedList.Add(list1[pos1]);
                pos1++;
            }
            else if (list1[pos1] <= list2[pos2]) {
                mergedList.Add(list1[pos1]);
                pos1++;
            } else {
                mergedList.Add(list2[pos2]);
                pos2++;
            }
        }
        return mergedList;
    }

    public List<int> MergeSortHelper(int[] array, int left, int right) {
        if (left == right) {
            return new List<int>{ array[left] };
        }
        else {
            int middle = (left + right) / 2;
            List<int> listLeft =  MergeSortHelper(array, left, middle);
            List<int> listRight =  MergeSortHelper(array, middle + 1, right);
            return MergeLists(listLeft, listRight);
        }
    }
    public int[] BubbleSort(int[] array) {
        if (array == null) {
            return new int[]{};
        } else {
            int length = array.Length;
            if (length <= 1) {
                return array;
            } else {
                while (length > 1) {
                    for (int i = 0; i < length - 1; i++) {
                        if (array[i] > array[i + 1]) {
                            int temp = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = temp;
                        }
                    }
                    length--;
                }
                return array;
            }
        }
    }

    public int[] QuickSort(int[] array) {
        if (array == null) {
            return null;
        }
        else if (array.Length <= 1) {
            return array;
        }
        else {
            QuickSortHelper(ref array, 0, array.Length - 1);
            return array;
        }
    }

    public void QuickSortHelper(ref int[] array, int start, int end) {
        if (start > end) return;
        int pivot = PickPivot(start, end);
        int temp;
        for (int i = start; i <= end; i++) {
            if ((array[i] > array[pivot] && i < pivot) || (array[i] < array[pivot] && i > pivot)) {
                temp = array[i];
                array[i] = array[pivot];
                array[pivot] = temp;
                pivot = i;
            }
        }
        QuickSortHelper(ref array, start, pivot - 1);
        QuickSortHelper(ref array, pivot + 1, end);
    }


    public int PickPivot(int start, int end) {
        //return (start + end)/2;
        return start;
    }
}