class Solution(object):
    def maxArea(self, height):
        """
        :type height: List[int]
        :rtype: int
        """
        res = float('-inf')

        left, right = 0, len(height) - 1

        while left < right:
            width = right - left 
            contain_water =( width) * (min(height[left], height[right]))

            res = max(contain_water, res)
            # keep the longer height 
            if height[left] < height[right]:
                left += 1
            else:
                right -= 1
        return res 