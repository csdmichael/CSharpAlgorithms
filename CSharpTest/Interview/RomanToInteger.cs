using System.Text.RegularExpressions;

public class RomanToInteger {
    public int RomanToInt(string s) {
        Dictionary<string,int> spec = new Dictionary<string,int>();
        spec.Add("IV", 4);
        spec.Add("IX", 9);
        spec.Add("XL", 40);
        spec.Add("XC", 90);
        spec.Add("CD", 400);
        spec.Add("CM", 900);

        Dictionary<string,int> symb = new Dictionary<string,int>();
        symb.Add("I", 1);
        symb.Add("V", 5);
        symb.Add("X", 10);
        symb.Add("L", 50);
        symb.Add("C", 100);
        symb.Add("D", 500);
        symb.Add("M", 1000);

        int value = 0;
        if (s.Length > 1) {
            //Assess Special
            foreach (KeyValuePair<string,int> sp in spec) {
                int index = s.IndexOf(sp.Key);
                while (index > -1) {
                    value += sp.Value;
                    s = s.Substring(0, index) + s.Substring(index + 2);
                    index = s.IndexOf(sp.Key);
                }
            }
        }
        foreach (KeyValuePair<string,int> sy in symb) {
            int index = s.IndexOf(sy.Key);
            while (index > -1) {
                    value += sy.Value;
                    s = s.Substring(0, index) + s.Substring(index + 1);
                    index = s.IndexOf(sy.Key);
            }
        }

        return value;
    }
}