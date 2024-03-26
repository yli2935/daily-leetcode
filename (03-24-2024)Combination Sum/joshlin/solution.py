from typing import List

class Solution:
    # 遍历，创建n叉树
    def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
        res = []
        def backtrack(startIndex: int, curr: List[List[int]], total:int):
            if total == target:
                res.append(curr.copy())
                return
            if total > target:
                return

            for i in range(startIndex, len(candidates)):
                curr.append(candidates[i])
                backtrack(total + candidates[i], curr, i)
                curr.pop()

        backtrack(0, [], 0)
        return res
    
    # 使用二叉树
    def combinationSum(self, candidates: List[int], target: int) -> List[List[int]]:
        res = []
        def backtrack(index: int, curr: List[int], total: int):
            if total == target:
                res.append(curr.copy())
                return
            if total > target or index >= len(candidates):
                return
            
            curr.append(candidates[index])
            backtrack(index, curr, total + curr)
            curr.pop()
            backtrack(index + 1, curr, total)
        
        backtrack(0, [], 0)
        return res


