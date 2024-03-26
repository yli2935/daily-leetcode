from typing import List

class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        count = {}
        threshold = len(nums) // 2
        for num in nums:
            count[num] = count.get(num, 0) + 1
            if count[num] > threshold:
                return num

    def majorityElement(self, nums: List[int]) -> int:
        majority, count = nums[0], 1
        for i in range(1, len(nums)):
            if count == 0:
                count += 1
                majority = nums[i]
            elif majority == nums[i]:
                count += 1
            else:
                count -= 1
        return majority