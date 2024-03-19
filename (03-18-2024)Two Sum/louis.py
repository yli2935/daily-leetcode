class Solution(object):
    def twoSum(self, nums, target):
        countMap = {}

        for index, value in enumerate(nums):
            complete = target - value

            if complete in countMap:
                return [countMap[complete], index]
            
            countMap[value] = index