public class MaxNumOfVowels {
     public int MaxVowels(string s, int k) {
        if (k == 0) return 0;
        int max = 0;
        for (int i = 0; i <= s.Length - k; i++) {
            int count = GetMax(s, i, i + k - 1);
            if (count > max) {
                max = count;
            }
        }
        return max;
    }

    public int GetMax(string s, int start, int end) {
        string vowels = "aeiou";
        int count = 0;
        for (int i = start; i <= end; i++) {
            if (vowels.IndexOf(s[i]) >= 0) {
                count++;
            }
        }
        return count;
    }
}