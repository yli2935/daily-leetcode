<!--
 * @Description: temp
-->
# 57. Insert Interval
### portal: [Insert Interval](https://leetcode.com/problems/insert-interval/description/)
## Problem Description

Given a set of **non-overlapping** intervals `intervals` where intervals[i] = [start_i, end_i], insert a new interval `newInterval` = [start_new, end_new] into the intervals array (merge if necessary).

You may assume that the intervals were initially sorted according to their start times.

**Examples:**

```plaintext
Example 1:
Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]
Explanation: Inserting newInterval [2,5] between [1,3] and [6,9] will result in [1,5],[6,9].

Example 2:
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Inserting newInterval [4,8] between [3,5] and [6,7] will result in [3,10],[12,16]. It should be noted that the new interval [4,8] overlaps with [3,5],[6,7],[8,10].

Example 3:
Input: intervals = [], newInterval = [5,7]
Output: [[5,7]]

Example 4:
Input: intervals = [[1,5]], newInterval = [2,3]
Output: [[1,5]]

Example 5:
Input: intervals = [[1,5]], newInterval = [2,7]
Output: [[1,7]]
```

**Constraints:**

- `0 <= intervals.length <= 10^4`
- `intervals[i].length == 2`
- `0 <= start_i <= end_i <= 10^5`
- `intervals` is sorted by `start_i` in **ascending** order.
