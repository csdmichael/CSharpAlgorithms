public class GroupShiftedStrings{
    private int CalculateDisance(char prev, char curr) {
        int p = prev - 'a';
        int c = curr - 'a';
        if (c >= p) {
            return c - p;
        } else {
            return 26 + (c - p);
        }
    }
    public List<List<string>> GetShiftedStrsGroups(string[] strings) {
        List<List<string>> res = new List<List<string>>();
        if (strings == null) return res;
        else if (strings.Length == 0) return res;
        else if (strings.Length == 1) {
            res.Add(strings.ToList());
            return res;
        }
        else {
            Dictionary<string, List<string>> dictData = new Dictionary<string, List<string>>();
            foreach (string s in strings) {
                string key = "";
                for (int i = 1; i < s.Length; i++) {
                    char prev = s[i-1], curr = s[i];
                    int dist = CalculateDisance(prev, curr);
                    key += dist.ToString() + "-";
                }
                List<string> group;
                if (dictData.ContainsKey(key)) {
                    group = dictData[key];
                } else {
                    group = new List<string>();
                    dictData.Add(key, group);
                }
                group.Add(s);
            }
            res = dictData.Values.ToList();
            return res;
        }
        
    }
}