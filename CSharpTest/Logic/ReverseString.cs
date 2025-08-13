public class ReverseString {

    private string Reverse_Helper(string sub, int start, int end) {
        while (start >= 0 && sub[start] != ' ') {
            start--;
        }
        string rev = sub.Substring(start + 1, end - start);
        string rev2 = "";
        if (start > 0) {
            end = start - 1;
            start--;
            string reminder = sub.Substring(0, end + 1);
            rev2 = Reverse_Helper(reminder, start, end);
        }
        if (rev2.Length > 0) {
            return rev + " " + rev2;
        }
        else return rev;
    }
    public string Reverse(String s)
    {
        if (s == null) return null;
        else if (s.Length < 2) return s;
        else {
            int end = s.Length - 1;
            int start = end;
            string res = Reverse_Helper(s, start, end);
            return res;
        }
    }
}