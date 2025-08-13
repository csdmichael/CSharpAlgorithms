public class StringAnagrams {
    public bool AreWordsAnagrams(string s1, string s2) {
        if (s1 == null && s2 == null) {
            return true;
        }
        else if (s1 == null || s2 == null) {
            return false;
        } 
        else if (s1.Length != s2.Length) {
            return false;
        } 
        else if (s1.Length == 0 && s2.Length == 0) {
            return true;
        } 
        else {
            Dictionary<char, int> charOccurences = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++) {
                if (charOccurences.ContainsKey(s1[i])) {
                    charOccurences[s1[i]]++;
                } else {
                    charOccurences.Add(s1[i], 1);
                }
            }

            for (int i = 0; i < s2.Length; i++) {
                if (charOccurences.ContainsKey(s2[i])) {
                    int occur = charOccurences[s2[i]] - 1;
                    if (occur <= 0) {
                        charOccurences.Remove(s2[i]);
                    } else {
                        charOccurences[s2[i]] = occur;
                    }
                } else {
                    return false;
                }
            }

            if (charOccurences.Count == 0) 
                return true;
            else 
                return false;
        }

    }
}