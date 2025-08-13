public class HappyNumber {
    public bool IsHappy(int n) {
        if (n == 1) return true;
        
        Dictionary<int, bool> d = new Dictionary<int,bool>();
        int sqAdd = Calc(n);
        while (sqAdd != 1) {
            sqAdd = Calc(sqAdd);
            if (d.ContainsKey(sqAdd)){
                return false;
            }
            else {
                d.Add(sqAdd, true);
            }
        }
        return true;
    }

    public int Calc(int n) {
        string s = n.ToString();
        int sqAdd = 0;
        for (int i = 0; i < s.Length; i++) {
            char curr = s[i];
            int val = (int)Char.GetNumericValue(curr); //VIP
            sqAdd += (val * val);
        }
        return sqAdd;
    }
}

/*
n = 2
4
16
37
58
89 = 25+64
145
1+16+25 = 42
16 + 4 = 20
4
*/
