<!--
 * @Description: temp
-->
# 252. Meeting Rooms
### portal: [Meeting Rooms](https://leetcode.com/problems/meeting-rooms/)
## Problem Description

Given an array `intervals` where `intervals[i] = [start_i, end_i]`, return `true` if you can attend all meetings and `false` otherwise.

The same time slot may be occupied by more than one meeting.

**Examples:**

```plaintext
Example 1:
Input: intervals = [[0,30],[5,10],[15,20]]
Output: false
Explanation: 
The first meeting starts at time 0 and ends at time 30.
The second meeting starts at time 5 and ends at time 10.
The third meeting starts at time 15 and ends at time 20.
Meeting 1 and 3 overlap, so you can't attend all meetings.

Example 2:
Input: intervals = [[7,10],[2,4]]
Output: true
Explanation: 
The first meeting starts at time 7 and ends at time 10.
The second meeting starts at time 2 and ends at time 4.
The second meeting ends before the first meeting starts, so you can attend both meetings.
```

**Constraints:**

- `1 <= intervals.length <= 10^4`
- `intervals[i].length == 2`
- `0 <= start_i < end_i <= 10^6`
