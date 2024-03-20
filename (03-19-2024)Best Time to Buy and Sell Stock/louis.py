class Solution(object):
    def maxProfit(self, prices):
        max_profit,  min_price = float('-inf'), float('inf')
        
        for price in prices:
            min_price = min(price, min_price)

            profit = price - min_price

            max_profit = max(profit, max_profit)
        
        return max_profit