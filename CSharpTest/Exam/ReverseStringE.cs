public class ReverseStringE {
    public string Reverse(string s) {
        if (s == null) {
            return null;
        } else if (s.Length <= 1) {
            return s;
        } else {
            Char[] chars = s.ToCharArray();
            ReverseWord(ref chars, 0, s.Length - 1);
            int start = 0, end = 0;
            while (end < chars.Length) { //Revisit
                if (end == chars.Length - 1) {
                    ReverseWord(ref chars, start, end);
                    start = end + 1;
                    end = start;
                }
                else if (chars[end] != ' ') {
                    end++;
                }
                else {
                    ReverseWord(ref chars, start, end - 1);
                    start = end + 1;
                    end = start;
                }
            }
            return new string(chars);
        }
    }

    private void ReverseWord(ref char[] chars, int start, int end) {
        while (end > start) {
            char temp = chars[end];
            chars[end] = chars[start];
            chars[start] = temp;
            start++;
            end--;
        }
    }
}

/*
Hello World
    dlroW olleH
    World Hello

    O(N)
*/