public class StockMaxProfit {
    private int GetMax(int[] prices, int startAt) {
        int max = 0;
        for(int j = startAt; j < prices.Length; j++) {
            if (prices[j] > max) {
                max = prices[j];
            }
        }
        return max;
    }
    public int GetMaxProfit(int[] prices) {
        if (prices == null) {
            return 0;
        }
        else if (prices.Length <= 1) {
            return 0;
        }
        else {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++) {
                int currBuy = prices[i];
                int maxSell = GetMax(prices, i + 1);
                int profit = maxSell - currBuy;
                if (profit > maxProfit) {
                    maxProfit = profit;
                }
            }

            return maxProfit;
        }
    }
}