public class ValidParentheses {
    public bool IsValid(string s) {
        if (s == null) { return true; }
        else if (s.Length == 0) { return true;}
        else {
            Stack<int> stkRound = new Stack<int>();
            Stack<int> stkCurly = new Stack<int>();
            Stack<int> stkSquare = new Stack<int>();
            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if (c == '(') {
                    stkRound.Push(i);
                }
                else if (c == ')') {
                    if (stkRound.Count > 0) {
                        stkRound.Pop();
                    }
                    else {
                        //Stack Empty
                        return false;
                    }
                }
                else if (c == '{') {
                    stkCurly.Push(i);
                }
                else if (c == '}') {
                    if (stkCurly.Count > 0) {
                        stkCurly.Pop();
                    }
                    else {
                        //Stack Empty
                        return false;
                    }
                }
                else if (c == '[') {
                    stkSquare.Push(i);
                }
                else if (c == ']') {
                    if (stkSquare.Count > 0) {
                        stkSquare.Pop();
                    }
                    else {
                        //Stack Empty
                        return false;
                    }
                }
            }
            if (stkCurly.Count > 0 || stkSquare.Count > 0 || stkRound.Count > 0) {
                return false;
            }

            
            return true;
        }
    }
}