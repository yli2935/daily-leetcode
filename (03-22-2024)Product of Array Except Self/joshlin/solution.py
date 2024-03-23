
from typing import List

class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        # [1, 2, 3, 4]
        #  1  1  2  6  left to right
        #  24 12 4  1  right to left
        #  24 12 8  6  return list
        res = [1] * len(nums)
        left, right = 1, 1

        for i in range(1, len(nums)):
            left *= nums[i - 1]
            res[i] = left
        
        for i in range(len(nums)-2, -1, -1):
            right  *= nums[i + 1]
            res[i] *= right

        return res