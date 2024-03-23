#if the arrary of intervals are not sorted, either brutal force O(n^2) or sort first and loop should be O(nlogn) for time complexity
#liner search time O(N)  space O(1)
class Solution:
    def insert(self, intervals: List[List[int]], newInterval: List[int]) -> List[List[int]]:
        n = len(intervals)
        i = 0
        result = []

        # case 1 : The current interval ends before the new interval starts.
        while i < n and intervals[i][1] < newInterval[0]:
            result.append(intervals[i])
            i += 1 

        # case 2 : There is an overlap, and the intervals need merging.
        while i < n and newInterval[1] >= intervals[i][0]:
            newInterval[0] = min(newInterval[0], intervals[i][0])
            newInterval[1] = max(newInterval[1], intervals[i][1])
            i += 1
        #need to put this line out of loop otherwise, it will append new interveal every iteration
        result.append(newInterval)
            

        # case 3 : The current interval starts after the new interval ends.
        while i < n and newInterval[1] < intervals[i][0]:
            result.append(intervals[i])
            i += 1 

        return result

# Use binary search to optimize maybe