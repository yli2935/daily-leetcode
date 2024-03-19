from typing import List

class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        # time: O(n), space: O(1)
        if len(prices) < 2:
            return 0
        max_profit, min_stock = float('-inf'), prices[0]
        for price in prices:
            max_profit = max(max_profit, price - min_stock)
            min_stock = min(min_stock, price)
        return max_profit