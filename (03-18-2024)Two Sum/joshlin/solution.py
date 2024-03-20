from typing import List

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        # time: O(n), space: O(n)
        complement = {}
        for index, num in enumerate(nums):
            diff = target - num
            if diff in complement:
                return [index, complement[diff]]
            else:
                complement[num] = index