public class StringAnagramsE{
    public bool AreWordsAnagrams(string s1, string s2) {
        if (s1 == null && s2 == null) return true;
        if (s1 == null || s2 == null) return false;
        if (s1.Length != s2.Length) return false;
        Dictionary<char,int> hashOccur = new Dictionary<char, int>();
        foreach(char c in s1) {
            if (hashOccur.ContainsKey(c)) {
                hashOccur[c]++;
            } else {
                hashOccur.Add(c, 1);
            }
        }

        foreach(char c in s2) {
            if (hashOccur.ContainsKey(c)) {
                int occur = hashOccur[c];
                if (occur == 1) {
                    hashOccur.Remove(c);
                } else {
                    hashOccur[c]--;
                }
            } else {
                return false;
            }
        }

        return true;
    }
}

/*
    ABCA, CBAA
1) build hash and populate based on s1
    A 2
    B 1
    C 1
2) loop on chars in s2, remove from hash

Time: O(n) 
Space: O(n)
*/