/*
 * @Description: temp
 */
class Solution {

    public int maxProfit(int[] prices) {
        int maxProfit = 0;
        int minValue = Integer.MAX_VALUE;
        for(int i = 0;i<prices.length;i++){
            minValue = Math.min(minValue,prices[i]);
            maxProfit = Math.max(maxProfit,prices[i] - minValue);
        }
        return maxProfit;
    }

    // public int maxProfit(int[] prices) {
    //     int min = Integer.MAX_VALUE;
    //     int maxProfit = 0;
    //     for(int i = 0;i<prices.length;i++){
    //         if(prices[i] < min){
    //             min = prices[i];
    //         }else{
    //             maxProfit = Math.max(maxProfit,prices[i] - min);
    //         }
    //     }
    //     return maxProfit;
    // }

}