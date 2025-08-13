public class RansomNote {
    public bool CanConstruct(string ransomNote, string magazine) {

        if (ransomNote.Length == 0) return true;
        Dictionary<char,int> d = new Dictionary<char, int>();
        for (int i = 0; i < magazine.Length; i++) {
            char curr = magazine[i];
            if (d.ContainsKey(curr)) {
                d[curr]++;
            }
            else {
                d.Add(curr, 1);
            }
        }

        for(int i = 0; i < ransomNote.Length; i++) {
            char curr = ransomNote[i];
            if (d.ContainsKey(curr)) {
                d[curr]--;
                if (d[curr] == 0) {
                    d.Remove(curr);
                }
            }
            else {
                return false;
            }
        }

        return true;
    }
}