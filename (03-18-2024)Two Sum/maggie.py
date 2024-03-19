'''
# brute force: nested loop
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
       
        n = len(nums)
        for i in range (n-1):
            for j in range (i+1, n):
                if nums[i] + nums[j] == target:
                    return[i,j]
        return []
'''

#use hash table
class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        numMap = {}
        n = len(nums)
        for i in range(n):
            numMap[nums[i]] = i

        for i in range(n):
            rest = target - nums[i]
            if rest in numMap and numMap[rest] !=i:
                return [i, numMap[rest]]
        return []