class Solution(object):
    def productExceptSelf(self, nums):
        n = len(nums)

        res = [1] * n 
        pre_fix = 1

        # prefix, updating prefix 
        for i in range(n):
            res[i] = pre_fix 
            pre_fix *= nums[i]

        post_fix = 1
        
        for j in range(n - 1, -1, -1):
            res[j] = res[j] * post_fix
            post_fix *= nums[j]
        
        return res 
    
