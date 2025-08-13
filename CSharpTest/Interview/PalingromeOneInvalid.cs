public class PalingromeOneInvalid {
    public bool IsValidPalingrome(string s) {
        if (s == null) return true;
        if (s.Length <= 1) return true;
        int count = CountInValid(s, 0, s.Length - 1);
        if (count > 1) return false;
        else return true;
    }

    public int CountInValid(string s, int start, int end) {
        if (start < end) {
            int ctr1 = 0, ctr2 = 0, ctr3 = 0;
            if (s[start]==s[end]) {
                start++;
                end--;
                ctr1 = ctr1 + CountInValid(s, start, end);
            }
            else {
                start++;
                ctr2 += 1 + CountInValid(s, start, end);
                start--;
                end--;
                ctr3 += 1 + CountInValid(s, start, end);
                if (ctr2 < ctr3) {
                    ctr1 = ctr2;
                }
                else {
                    ctr1 = ctr3;
                }
            }
            return ctr1;
        }
        else return 0;
        
    }
}