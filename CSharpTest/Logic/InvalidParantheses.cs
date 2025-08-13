public class InvalidParantheses {
    public string RemoveMinInvalidParantheses(string s) {
        if (s == null) { return s; }
        else if (s.Length == 0) { return s;}
        else {
            Stack<int> stkIndexes = new Stack<int>();
            List<int> lstIndexesToRemove = new List<int>();
            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if (c == '(') {
                    stkIndexes.Push(i);
                }
                else if (c == ')') {
                    if (stkIndexes.Count > 0) {
                        stkIndexes.Pop();
                    }
                    else {
                        //Stack Empty
                        lstIndexesToRemove.Add(i);
                    }
                }
            }
            if (stkIndexes.Count > 0) {
                int sLen = stkIndexes.Count;
                for (int i = 0; i < sLen; i++) {
                    int index = stkIndexes.Pop();
                    lstIndexesToRemove.Add(index);
                }
            }

            string res = "";
            for (int i = 0; i < s.Length; i++) {
                if (!lstIndexesToRemove.Contains(i)) {
                    char c = s[i];
                    res += c;
                }
                
            }
            return res;
        }
    }
}