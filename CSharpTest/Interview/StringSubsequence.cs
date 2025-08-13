public class StringSubsequence{
    public bool IsSubsequence(string s, string t) {
        
        if (s.Length == 0) return true;

        int p1 = 0;
        int p2 = 0;

        while (p1 < s.Length && p2 < t.Length) {
            if (s[p1] == t[p2]) {
                p1++;
                p2++;
            }
            else {
                p2++;
            }
        }

        if (p2 == t.Length && p1 < s.Length) return false;
        else return true;
    }
}