public class ListAlgorithms {
    public List<int> CommonElementsTwoLists(int[] arr1, int[] arr2) {
        int pos1 = 0; int pos2 = 0;
        List<int> commonList = new List<int>();
        if (arr1 == null || arr2 == null) {
            return commonList;
        }
        else if (arr1.Length == 0 || arr2.Length == 0) {
            return commonList;
        }
        else {
            while (pos1 < arr1.Length && pos2 < arr2.Length) {
                if (arr1[pos1] == arr2[pos2]) {
                    commonList.Add(arr1[pos1]);
                    Console.WriteLine(arr1[pos1]);
                    pos1++;
                    pos2++;
                }
                else if (arr1[pos1] > arr2[pos2]) {
                    pos2++;
                }
                else if (arr2[pos2] > arr1[pos1]) {
                    pos1++;
                }
            }

            return commonList;
        }

    }
}