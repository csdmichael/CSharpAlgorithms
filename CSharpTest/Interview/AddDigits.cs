public class DigitsAddition {
    public int AddDigits(int num) {
        string s = num.ToString();
        while (s.Length > 1) {
            int add = SumDigits(s);
            s = add.ToString();
        }
        return SumDigits(s);
    }

    private int SumDigits(string s) {
        int sum = 0;
        for(int i = 0; i < s.Length; i++) {
            char c = s[i];
            int d = System.Convert.ToInt16(new String(c, 1));
            sum += d;
        }
        return sum;
    } 

}