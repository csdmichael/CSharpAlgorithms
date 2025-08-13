public class ReverseStringInPlace {
    public string ReverseString(string s) {
        if (s == null) {
            return null;
        } else if (s.Length <= 1) {
            return s;
        } else {
            s= s.Trim();
            int blanks = s.IndexOf("  ");
            while (blanks >= 0)
            {
                s = s.Replace("  ", " ");
                blanks = s.IndexOf("  ");
            }
            char[] chars = s.ToCharArray();
            ReverseStringHelper(ref chars, 0, s.Length - 1);
            int start = 0, index = 0;
            while (index < s.Length) {
                if (chars[index] == ' ') {
                   ReverseStringHelper(ref chars, start, index-1);
                    index++;
                    start = index;
                }
                else if (index == chars.Length - 1) {
                    ReverseStringHelper(ref chars, start, index);
                    break;
                }
                else {
                    index++;
                }
            }
            return new string(chars);
        }
    }

    private void ReverseStringHelper(ref char[] chars, int start, int end) {
        while (end > start) {
            char temp = chars[start];
            chars[start] = chars[end];
            chars[end] = temp;
            start++;
            end--;
        }
    }
}