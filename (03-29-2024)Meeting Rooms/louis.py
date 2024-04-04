class Solution(object):
    def canAttendMeetings(self, intervals):
        """
        :type intervals: List[List[int]]
        :rtype: bool
        """
        if not intervals:
            return True 
        intervals = sorted(intervals, key= lambda x: x[0])
        check = [intervals[0][1]]
        
        for start, end in intervals[1:]:
            if start < check[-1]:
                return False 
            else:
                check.append(end)
        return True 