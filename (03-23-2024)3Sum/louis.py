class Solution(object):
    def threeSum(self, nums):
        nums = sorted(nums)
        res = []
        for i in range(len(nums)):
            if i > 0 and nums[i] == nums[i - 1]:
                continue 

        # two pointer, left will be after i 
            left, right = i + 1, len(nums) -1 

            while left < right:
                target = nums[left] + nums[right] + nums[i]

                if target < 0:
                    left += 1
                elif target > 0:
                    right -= 1
                else:
                    res.append([nums[left], nums[right], nums[i]])
                
                    while left < right and nums[left] == nums[left + 1]:
                        left += 1 
                    while left < right and nums[right] == nums[right - 1]:
                        right -= 1 
                
                    left += 1
                    right -= 1
        
        return res