from typing import List

class Solution:
    """
    双指针，这个应该属于greedy algorithm？每次替换掉短板，才可能找到更大的容量
    """
    def maxArea(self, height: List[int]) -> int:
        l, r = 0, len(height) - 1
        res = 0
        while l < r:
            res = max(res, min(height[l], height[r]) * (r - l))
            if height[l] < height[r]:
                l += 1
            else:
                r -= 1
        return res
