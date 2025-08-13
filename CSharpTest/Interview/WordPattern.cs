public class WordPattern {
    public bool IsWordPattern(string pattern, string s) {
        Dictionary<char,int> dp = new Dictionary<char,int>();
        Dictionary<string,int> ds = new Dictionary<string,int>();

        string[] words = s.Split(' ');

        if (words.Length != pattern.Length) {
            return false;
        }

        for(int i = 0; i < pattern.Length; i++) {
            string w = words[i];
            char c = pattern[i];
            if (
                    (dp.ContainsKey(c) && !ds.ContainsKey(w))
                    || (!dp.ContainsKey(c) && ds.ContainsKey(w))
               ) {
                   return false;
            }
            else if (dp.ContainsKey(c)) {
                int wordI = ds[w];
                int charI = dp[c];
                if (wordI != charI) return false;
            }
            else if (!dp.ContainsKey(c)) {
                dp.Add(c, i);
                ds.Add(w, i);
            }
            
        }

        return true;
    }
}

/*
Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.

 

Example 1:

Input: pattern = "abba", s = "dog cat cat dog"
Output: true
Example 2:

Input: pattern = "abba", s = "dog cat cat fish"
Output: false
Example 3:

Input: pattern = "aaaa", s = "dog cat cat dog"
Output: false
 

Constraints:

1 <= pattern.length <= 300
pattern contains only lower-case English letters.
1 <= s.length <= 3000
s contains only lowercase English letters and spaces ' '.
s does not contain any leading or trailing spaces.
All the words in s are separated by a single space.
*/