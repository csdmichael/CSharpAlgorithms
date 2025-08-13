public class MinCostClimbingStairs {
    public int GetMinCostClimbingStairs(int[] cost) {
        int[] sum = new int[cost.Length];
        for (int i = 0; i < cost.Length; i++) {
            if (i < 2) {
                sum[i] = cost[i];
            }
            else {
                sum[i] = cost[i] + GetMin(sum[i-1], sum[i-2]);
            }
        }

        int res = GetMin(sum[sum.Length - 1], sum[sum.Length - 2]);
        return res;
    }

    public int GetMin(int x, int y) {
        if (x < y) return x;
        else return y;
    }
}

/*



*/