public class InvalidPAranthesesE {
    public string RemoveMinInvalidParantheses(string s) {
        if (s == null) return null;
        if (s.Length == 0) return s;
        
        Stack<int> stkIndexes = new Stack<int>();
        Dictionary<int, int> lstIndexesToRemove = new Dictionary<int, int>();

        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            if (c == '(') {
                stkIndexes.Push(i);
            } else if (c == ')') {
                if (stkIndexes.Count == 0) {
                    lstIndexesToRemove.Add(i, i);
                } else {
                    stkIndexes.Pop();
                }
            }
        }

        while (stkIndexes.Count > 0) {
            int x = stkIndexes.Pop();
            lstIndexesToRemove.Add(x, x);
        }

        string res = "";
        for (int i = 0; i < s.Length; i++) {
            char c = s[i];
            if (!lstIndexesToRemove.ContainsKey(i)) {
                res += c;
            }
        }
        return res;
    }
}

/*
((AB)c)))
(A(CD)

1)
Stk
IndicesToRemove 7,8

2)
Stk  
IndicesToRemove 0

Time: O(n)
Space: O(n)
*/