public class LongestCommonPrefix{
    public string GetLongestCommonPrefix(string[] strs) {
        string cp = strs[0];
        for (int i = 1; i < strs.Length; i++) {
            string curr = strs[i];
            cp = GetCommonPrefix(cp, curr);
        }
        return cp;
    }

    private string GetCommonPrefix(string s1, string s2) {
        string common = "";
        int len = (s1.Length > s2.Length)? s2.Length: s1.Length;
        for (int i = 0; i < len; i++) {
            if (s1[i] == s2[i]) {
                common = common + s1[i];
            }
            else {
                break;
            }
        }
        return common;
    }
}