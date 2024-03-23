# use two pointer 
# always make sure the left is the lowest 
class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        #left point to buy at lowest price, right pointer to sell at highest price moving forward, cannot go backwards
        left, right = 0, 1
        max_profit = 0

        while right < len(prices):
            currentProfit = prices[right] - prices[left]
            if prices[left] < prices[right]:
                max_profit = max(currentProfit, max_profit)
            else:
                #make sure the left pointer will be the lowest one
                left = right
            right += 1
        return max_profit