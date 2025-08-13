public class DecimalToBinary {
    public string ConvertToBits(uint n) {
        if (n == 0) return "0";
        Dictionary<uint, int> d = new Dictionary<uint, int>();
        uint key = 1;
        int value = 1;
        while (key <= n) {
            d.Add(key, value);
            key *= 2;
            value *= 10;
        }
        int bin = 0;
        while (n > 0) {
            uint k = d.Keys.ElementAt(d.Count - 1);
            int v = d.Values.ElementAt(d.Count - 1);
            d.Remove(k);
            if (k <= n) {
                bin += v;
                n -= k;
            }
        }
        return bin.ToString();
    }
}