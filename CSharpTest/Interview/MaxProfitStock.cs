public class MaxProfitStock {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length - 1; i++) {
            int buy = prices[i];
            int maxSell = GetMax(prices, i + 1);
            int profit = maxSell - buy;
            if (profit > maxProfit) {
                maxProfit = profit;
            }
        }
        return maxProfit;
    }

    private int GetMax(int[] prices, int start) {
        int max = 0;
        for (int i = start; i < prices.Length; i++) {
            int curr = prices[i];
            if (curr > max) {
                max = curr;
            }
        }
        return max;
    }

}