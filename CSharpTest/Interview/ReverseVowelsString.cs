public class ReverseVowelsString {
    public string ReverseVowels(string s) {
        if (s.Length <=1) return s;
        char[] chars = s.ToCharArray();
        int p1 = 0, p2 = s.Length - 1;
        while (p2 > p1) {
            bool v1 = IsVowel(s[p1]);
            bool v2 = IsVowel(s[p2]);
            if (v1 && v2) {
                char temp = chars[p1];
                chars[p1] = chars[p2];
                chars[p2] = temp;
                p1++;
                p2--;
            }
            else if (v1) {
                p2--;
            }
            else if (v2) {
                p1++;
            }
            else {
                p1++;
                p2--;
            }
        }

        return new String(chars);
    }

    private bool IsVowel(char c) {
        string vowels = "aeiouAEIOU";
        if (vowels.IndexOf(c) >= 0) return true;
        else return false;
    }
}