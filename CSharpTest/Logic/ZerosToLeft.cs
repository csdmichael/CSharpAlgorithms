public class ZerosToLeft{
    public int[] MoveZerosLeft(int[] arr) {
        if (arr == null) return null;
        if (arr.Length <= 1) return arr;
        int ptr1 = 0, ptr2 = 0;
        while (ptr1 < arr.Length && ptr2 < arr.Length) {
            if (arr[ptr1] == 0) {
                ptr1++;
                ptr2 = ptr1;
            }
            else {
                if (arr[ptr2] != 0) {
                    ptr2++;
                } else {
                    for (int i = ptr2; i > ptr1; i--) {
                        arr[i] = arr[i-1];
                    }
                    arr[ptr1] = 0;
                    ptr1++;
                    ptr2++;
                }
            }
        }
        return arr;
    }
}

/*
1 2 0 7 0 0 3


ptr1 (non-Zero) 0
ptr2 (zero)     2
*/