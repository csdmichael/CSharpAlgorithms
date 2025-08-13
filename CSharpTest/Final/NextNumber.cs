public class NextNumberSameDigits {
    public int GetNextNumberSameDigits(int x) {
    
        char[] s = x.ToString().ToCharArray();
        if (s.Length <= 1) return x;
        int p = s.Length - 1;
        while (p > 0) {
            if (s[p-1] < s[p]) {
                char temp = s[p];
                s[p] = s[p-1];
                s[p-1] = temp;
                if (p < s.Length - 1) {
                    sort(ref s, p);
                }
                break;
            }
            p--;
        }

        string res = new string(s);
        return System.Convert.ToInt32(res);
    }

    private void sort(ref char[] s, int index) {
        if (s.Length - 1 - index > 1) {
            for (int i = index; i < s.Length - 1; i++) {
                for (int j = index + 1; j < s.Length; j++) {
                    if ((s[i] > s[j] && i < j) || (s[i] < s[j] && i > j)) {
                        char temp = s[i];
                        s[i] = s[j];
                        s[j] = temp;
                    }
                }
            }
        }
    }
}

/*
in: 123
out: 132

in: 647521 -> 674521
out: 671245
*/