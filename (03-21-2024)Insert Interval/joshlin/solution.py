from typing import List

class Solution:
    # 以下是初始写法，很多分类讨论和edge cases，太乱了，可读性差
    def insert(self, intervals: List[List[int]], newInterval: List[int]) -> List[List[int]]:
        if not newInterval:
            return intervals
        if not intervals:
            return [newInterval]
        start, end = newInterval[0], newInterval[1]
        res = []
        for index, interval in enumerate(intervals):
            currStart, currEnd = interval[0], interval[1]
            # Overlapped
            if start <= currEnd and end >= currStart:
                # Start within current
                if start >= currStart:
                    res.append([currStart])
                # Does not start within current
                # And this is the first element
                elif index == 0:
                    res.append([start])

                # End within current
                if end <= currEnd:
                    res[-1].append(currEnd)
                # Does not end within current
                # And this is the last element
                elif index == len(intervals) - 1:
                    res[-1].append(end)
            # Not Overlapped
            else:
                # Start after current
                if start > currEnd:
                    res.append(interval)
                    # This is the last interval
                    if index == len(intervals) - 1:
                        res.append(newInterval)
                    # Not last interval, start before next
                    if index < len(intervals) - 1 and start < intervals[index + 1][0]:
                        res.append([start])
                # End before current, after previous
                elif end < currStart:
                    # This is the first interval
                    if index == 0:
                        res.append(newInterval)
                    # Not the first interval, end before previous
                    elif index > 0 and end > intervals[index - 1][1]:
                        res[-1].append(end)
                    res.append(interval)
                # newInterval do not appear right next to current
                else:
                    res.append(interval)

        return res
    
    """
    分为三块处理：
    严格位于左边的（当前右端点 < newInterval左端点），直接添加
         eg.  newInterval:                     [          ]                     
              intervals[i]:   [          ]
    严格位于右边的（当前左端点 > newInterval右端点），直接添加
         eg.  newInterval:    [          ]                     
              intervals[i]:                    [          ]
    剩余的为重叠部分，只需取左端点min和右端点max即可
    """
    def insert(self, intervals: List[List[int]], newInterval: List[int]) -> List[List[int]]:
        start, end = newInterval[0], newInterval[1]
        left, right = [], []
        for interval in intervals:
            currStart, currEnd = interval[0], interval[1]
            if currEnd < start:
                left.append(interval)
            elif currStart > end:
                right.append(interval)
            else:
                start = min(start, currStart)
                end = max(end, currEnd)

        return left + [[start, end]] + right

    """
    同样分为三种情况，但这次用指针，遵循从左到右的顺序
    严格位于左边（当前右端点 < newInterval左端点），直接添加
    重叠部分：
      1. 由于已经排除了位于左边的部分，此后皆为（当前右端点 >= newInterval左端点）
         eg.  newInterval:    [        ]                     
              intervals[i]:               [             ]
      2. 这不足以确定是重叠的，我们加入条件（当前左端点 <= newInterval右端点）
         eg.  newInterval:    [        ]                     
              intervals[i]:         [                   ]
      3. 同样地，取左边min，右边max
    剩余部分严格位于右边，直接添加
    """
    def insert(self, intervals: List[List[int]], newInterval: List[int]) -> List[List[int]]:
        i = 0
        res = []
        while i < len(intervals) and intervals[i][1] < newInterval[0]:
            res.append(intervals[i])
            i += 1
        while i < len(intervals) and intervals[i][0] <= newInterval[1]:
            newInterval[0] = min(newInterval[0], intervals[i][0])
            newInterval[1] = max(newInterval[1], intervals[i][1])
            i += 1
        res.append(newInterval)
        while i < len(intervals):
            res.append(intervals[i])
            i += 1
        return res
