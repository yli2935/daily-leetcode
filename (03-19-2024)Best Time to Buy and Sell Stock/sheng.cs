namespace BestBuyAndSell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = [7, 1, 5, 3, 6, 4];
           // int[] prices = [7,6,4,3,1];
           // int[] prices = [1];
            Console.WriteLine(BestBuyAndSellBrouteForce(prices));
            Console.WriteLine(BestBuyAndSellSheng(prices));
            Console.WriteLine(MaxProfit(prices));
        }

        static int BestBuyAndSellBrouteForce(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[j] - prices[i] > maxProfit) { maxProfit = prices[j] - prices[i]; }
                }
            }
            return maxProfit;
        }

        static int BestBuyAndSellSheng(int[] prices)
        {
            int minvalue = prices[0];
            int maxProfit = 0;
                for(int i = 0;i < prices.Length - 1;i++) {
                if (prices[i] <minvalue) { minvalue = prices[i];}
                if (prices[i+1] - minvalue>maxProfit)
                {
                    maxProfit = prices[i+1]-minvalue;
                }
                else if (prices[i+1]<minvalue)
                {
                    minvalue = prices[i+1];
                }          
            }
                return maxProfit ;
        }
        //according to adam.java
        static int MaxProfit(int[] prices) {
            int maxProfit = 0;
            int minValue = int.MaxValue;
            for(int i = 0; i < prices.Length; i++)
            {
                minValue = Math.Min(minValue, prices[i]);
                maxProfit = Math.Max(maxProfit, prices[i]-minValue);
            }
            return maxProfit ;
        
        
        }
    }
}
