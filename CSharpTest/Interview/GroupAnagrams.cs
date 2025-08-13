public class GroupAnagrams {
    public IList<IList<string>> GetGroupAnagrams(string[] strs) {
        IList<IList<string>> res = new List<IList<string>>();

        Dictionary<string, IList<string>> d = new Dictionary<string, IList<string>>();
        for (int i = 0; i < strs.Length; i++){
            string curr = strs[i];
            string key = GenerateWordKey(curr);
            IList<string> group;
            if (d.ContainsKey(key)) {
                group = d[key];
            }
            else {
                group = new List<string>();
                d.Add(key, group);
            }
            group.Add(curr);
        }

        res = d.Values.ToList();
        return res;
    }

    private string GenerateWordKey(string s) {
        //Char: num of occurences
        SortedDictionary<char,int> dw = new SortedDictionary<char,int>();
        for(int i = 0; i < s.Length; i++) {
            char c = s[i];
            if (dw.ContainsKey(c)) {
                dw[c]++;
            }
            else {
                dw.Add(c,1);
            }
        }
        string key = "";

        foreach(KeyValuePair<char,int> kvp in dw) {
            key += kvp.Key + kvp.Value.ToString();
        }

        return key;
    }
}