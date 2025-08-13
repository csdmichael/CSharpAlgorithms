public class IsomorphicStrings {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char,int> ds = new Dictionary<char,int>(); 
        Dictionary<char,int> dt = new Dictionary<char,int>(); 

        for (int i = 0; i < s.Length; i++) {
            char cs = s[i];
            char ct = t[i];
            int indexOccureds, indexOccuredt;
            if (
                    (!ds.ContainsKey(cs) && dt.ContainsKey(ct)) || 
                    (ds.ContainsKey(cs) && !dt.ContainsKey(ct))
                ) {
                return false;
            }
            else if (ds.ContainsKey(cs)) {
                indexOccureds = ds[cs];
                indexOccuredt = dt[ct];
                if (indexOccureds != indexOccuredt) 
                    return false;
            }
            else {
                ds.Add(cs, i);
                dt.Add(ct, i);
            }
        }
        return true;
    }
}