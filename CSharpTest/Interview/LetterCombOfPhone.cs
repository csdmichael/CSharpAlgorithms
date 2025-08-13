public class LetterCombOfPhone {
    public IList<string> LetterCombinations(string digits) {
        
        Dictionary<char,string> d = new Dictionary<char,string>();
        d.Add('2',"abc");
        d.Add('3',"def");
        d.Add('4',"ghi");
        d.Add('5',"jkl");
        d.Add('6',"mno");
        d.Add('7',"pqrs");
        d.Add('8',"tuv");
        d.Add('9',"wxyz");

        IList<string> res = new List<string>();
        if (digits.Length == 0) {
            return res;
        }
        GetComb(digits, ref d ,ref res, "");
        return res;
    }

    private void GetComb(string digits, ref Dictionary<char,string> d, ref IList<string> res, string comb) {
        if (comb.Length == digits.Length) {
            res.Add(comb);
        }
        else {
            int len = comb.Length;
            char input = digits[len];
            string poss = d[input];
            for(int i = 0; i < poss.Length; i++) {
                GetComb(digits, ref d, ref res, comb + poss[i]);
            }
        }
    }
}