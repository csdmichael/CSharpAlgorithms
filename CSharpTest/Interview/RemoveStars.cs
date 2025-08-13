public class RemoveStarsAlgo{
    //using stack
    public string RemoveStars(string s) {
        Stack<char> chars = new Stack<char>();
        int  i = 0;
        while (i < s.Length) {
            chars.Push(s[i]);
            i++;
        } 
        string res = "";
        int remove = 0;
        while (chars.Count > 0) {
            char curr = chars.Pop();
            if (curr == '*') {
                remove++;
            }
            else if (remove > 0) {
                remove--;
            }
            else {
                res = curr + res;
            }
        }
        return res;
    }
    /*
    //using Recursion
    public string RemoveStars(string s) {
        return RemoveStarsHelper(s, 0);
    }

    public string RemoveStarsHelper(string s, int i) {
        while (i < s.Length - 1) {
            if (s[i+1] == '*') {
                string part1 = (i==0)?"": s.Substring(0, i);
                string part2 = (i+1 == s.Length - 1)?"" : s.Substring(i+2);
                return RemoveStarsHelper(part1 + part2, i-1);
            }
            else i++;
        }
        return s;
    }
    */

}