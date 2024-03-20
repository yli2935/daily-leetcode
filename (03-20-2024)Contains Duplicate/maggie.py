#brutal force may cause TLE ( time limits exceeds)
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        n = len(nums)
        for i in range(n - 1):
            for j in range(i + 1, n):
                if nums[i] == nums[j]:
                    return True
        return False


#hash map 
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        seen = {}
        for num in nums:
            #check if the key is unique or exsits in the map
            if num in seen:
                return True
            seen[num] = True
        return False
        