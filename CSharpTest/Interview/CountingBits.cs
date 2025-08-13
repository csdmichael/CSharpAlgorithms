public class CountingBits{
    public int[] CountBits(int n) {
        int[] res = new int[n+1];
        for (int i = 0; i <= n; i++) {
            res[i] = GetNumOfBits(i);
        }
        return res;
    }

    private int GetNumOfBits(int x) {
        if (x == 0) 
            return 0;
        else if (x == 1) 
            return 1;
        else {
            int bits = 0;
            int rem = x%2;
            if (rem==1) {
                bits++;
            }
            return bits + GetNumOfBits(x/2);
        }
    }
}