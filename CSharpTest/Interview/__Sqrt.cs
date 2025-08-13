public class Sqrt {
    public int MySqrt(int x) {
        int sq = 1;
        while (sq < x / sq)
        {
            sq++;           
        }
        if (sq > x / sq) return sq - 1;
        return sq;
    }
}