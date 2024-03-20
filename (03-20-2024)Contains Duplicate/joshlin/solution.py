from typing import List

class Solution:
    # time O(n) space O(n)
    # !!! bad practice because it won't break even if the first two numbers are the same
    def containsDuplicate(self, nums: List[int]) -> bool:
        return len(set(nums)) < len(nums)

    # time O(nlogn) space O(n)
    # look for consecutive repeating numbers
    def containsDuplicate(self, nums: List[int]) -> bool:
        sortedNums = sorted(nums)
        for index, num in enumerate(sortedNums):
            if index > 0 and num == sortedNums[index - 1]:
                return True
        return False
    
    # time O(n) space O(n)
    # check if count of any num > 1
    def containsDuplicate(self, nums: List[int]) -> bool:
        counter = {}
        for num in nums:
            counter[num] = counter.get(num, 0) + 1
            if counter[num] > 1:
                return True
        return False
    
    # time O(n) sapce O(n)
    # check if current num matches any in the hashset
    def containsDuplicate(self, nums: List[int]) -> bool:
        numSet = set()
        for num in nums:
            if num in numSet:
                return True
            numSet.add(num)
        return False
    
