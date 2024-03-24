class Solution(object):
    def combinationSum(self, candidates, target):    
        # dfs, find path, and adding together, meets the target return 
        res = []

        def dfs(i, path, path_sum):
            if path_sum == target:
                res.append(path)
                return 
            
            if path_sum > target:
                return 
            
            for i in range(i, len(candidates)):
                dfs(i, path + [candidates[i]], path_sum + candidates[i])
        
        dfs(0, [], 0)
        return res 