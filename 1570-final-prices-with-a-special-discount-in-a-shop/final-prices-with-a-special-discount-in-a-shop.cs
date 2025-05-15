public class Solution {
    public int[] FinalPrices(int[] prices) {
        for(var i = 0; i < prices.Length -1; i++){
            var j = i + 1;

            while(true){
                if (prices[i] >= prices[j]){
                    break;
                }

                if (j >= prices.Length - 1){
                    j = -1;
                    break;
                }

                j++;
            }

            if (j != -1){
                prices[i] = prices[i] - prices[j];
            }
        }

        return prices;
    }
}