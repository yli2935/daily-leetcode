class Solution(object):
    def insert(self, intervals, newInterval):
        res = []
        i = 0 

        # before overlapping happened
        while i < len(intervals) and intervals[i][1] < newInterval[0]:
            res.append(intervals[i])
            i += 1
        
        # overlapping
        while i< len(intervals) and intervals[i][0] <= newInterval[1]:
            newInterval = [min(intervals[i][0], newInterval[0]), max(intervals[i][1], newInterval[1])]
            i += 1
        res.append(newInterval)
        
        while i< len(intervals):
            res.append(intervals[i])
            i += 1

        return res