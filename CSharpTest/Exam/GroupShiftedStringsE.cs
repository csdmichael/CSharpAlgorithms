using System.Collections.Generic;
using System.Linq;

public class GroupShiftedStringsE{
    public List<List<string>> GetShiftedStrsGroups(string[] strings) {
        if (strings == null) {
            return null;
        } else if (strings.Length == 0) {
            return new List<List<string>>();
        } else {
            Dictionary<string, List<string>> res = new Dictionary<string, List<string>>();
            foreach(string s in strings) {
                string key = "";
                if (s.Length >= 2) {
                    for (int i = 0; i < s.Length - 1; i++) {
                        char curr = s[i];
                        char next = s[i+1];
                        int dist = CalcDist(curr, next);
                        key += dist.ToString() + "-";
                    }
                }
                if (res.ContainsKey(key)) {
                    List<string> group = res[key];
                    group.Add(s);
                } else {
                    res.Add(key, new List<string>() {s});
                }
            }
            return res.Values.ToList();
        }
    }

    public int CalcDist(char curr, char next) {
        int c = curr - 'a';
        int n = next - 'a';
        if (n >= c) {
            return n-c;
        } else {
            return 26 + (n-c);
        }
    }
}

/*
abc, def, adf, bc, a, d

"1-1"  abc, def
"3-2"  def
"1"    bc
""     a, d

O(n*c)
*/