public class NextLargerNum {
    //12345 -> 12354
    //321432 -> 322134

    private int GetMin(char[] chars, int start, int end) {
        int index = -1;
        char min = '9';
        for (int i = start; i <= end; i++) {
            if (chars[i] < min) {
                min = chars[i];
                index = i;
            }
        }
        return index;
    }

    private void Sort(ref char[] chars, int start, int end) {
        if (end - start < 2) {
            return;
        }
        for (int i = start; i <= end - 1; i++) {
            for (int j = start + 1; j <= end; j++) {
                if (chars[i] > chars[j]) {
                    char temp = chars[i];
                    chars[i] = chars[j];
                    chars[j] = temp;
                }
            }
        }
    }
    public int GetNextLargerNum(int x) {

        string s = x.ToString();
        if (s.Length == 1) return -1;
        char[] chars = s.ToCharArray();
        int ptr = chars.Length - 2;
        int digitToMove = -1;
        while (ptr >= 0) {
            if (chars[ptr] < chars[ptr+1]) {
                //swap char[ptr] with least from right substring and sort right substring
                digitToMove = ptr;
                char temp = chars[digitToMove];
                int least = GetMin(chars, ptr+1, chars.Length - 1);
                chars[digitToMove] = chars[least];
                chars[least] = temp;
                //Sort chars [ptr+1 -> chars.Length - 1]
                Sort(ref chars, ptr+1, chars.Length - 1);
                break;
            }
            else {
                ptr--;
            }
        }
        if (digitToMove == -1) {
            return -1;
        }
        else {
            s = new string(chars);
            int res = System.Convert.ToInt32(s);
            return res;
        }
    }
}