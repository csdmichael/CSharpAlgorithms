public class MergeStringsAlternately {
    public string MergeAlternately(string word1, string word2) {
        string res = "";

        int p1 = 0;
        int p2 = 0;

        while (p1 < word1.Length || p2 < word2.Length) {
            if (p1 == word1.Length) {
                res += word2[p2];
                p2++;
            } 
            else if (p2 == word2.Length) {
                res += word1[p1];
                p1++;
            }
            else {
                if (p1<=p2) {
                    res += word1[p1];
                    p1++;
                } else {
                    res += word2[p2];
                    p2++;
                }
            }
        }

        return res;
    }
}