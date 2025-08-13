using System.Text.RegularExpressions;

public class ValidPaligrome {
    public bool IsValidPaligrome(string s) {
        if (String.IsNullOrEmpty(s)) {
            return true;
        }
        else {
            s = Regex.Replace(s, "[^a-zA-Z0-9]", String.Empty);
            s = s.ToLower().Trim();
            if (String.IsNullOrEmpty(s)) {
                return true;
            } 
            else
                return IsValidPaligrome_Helper(s, 0, s.Length - 1);
        }
    }

    private bool IsValidPaligrome_Helper(string s, int start, int end) {
        if (start >= end) {return true;}
        else {
            bool eqCurr;
            bool eqRec;
            if (s[start] == s[end]) eqCurr = true;
            else eqCurr = false;
            eqRec = IsValidPaligrome_Helper(s, start + 1, end - 1);
            return eqCurr && eqRec;
        }
    }
}