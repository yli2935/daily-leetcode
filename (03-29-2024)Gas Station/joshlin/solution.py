from typing import List

class Solution:
    def canCompleteCircuit(self, gas: List[int], cost: List[int]) -> int:
        total, diff, start = 0, 0, 0
        for i in range(len(gas)):
            total += gas[i] - cost[i]
            diff += gas[i] - cost[i]
            if diff < 0:
                diff = 0
                start = i + 1
        return -1 if total < 0 else start