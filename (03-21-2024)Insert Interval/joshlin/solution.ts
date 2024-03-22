/* 
分为三块处理：
严格位于左边的（当前右端点 < newInterval左端点），直接添加
     eg.  newInterval:                     [          ]                     
          intervals[i]:   [          ]
严格位于右边的（当前左端点 > newInterval右端点），直接添加
     eg.  newInterval:    [          ]                     
          intervals[i]:                    [          ]
剩余的为重叠部分，只需取左端点min和右端点max即可
*/
function insert(intervals: number[][], newInterval: number[]): number[][] {
    let [start, end] = newInterval;
    const left: number[][] = [];
    const right: number[][] = [];
    for (const interval of intervals) {
        const [currStart, currEnd] = interval;
        if (currEnd < start) {
            left.push(interval);
        } else if (currStart > end) {
            right.push(interval);
        } else {
            start = Math.min(start, currStart);
            end = Math.max(end, currEnd);
        };
    };
    // 在TypeScript中,如果直接用[].concat(left,...);会报错，因为没有声明[]的类型
    // 另一种方法是使用 left.concat([[start, end]], right);
    return ([] as number[][]).concat(left, [[start, end]], right);
};

/*
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
*/
function insert_(intervals: number[][], newInterval: number[]): number[][] {
    const res: number[][] = [];
    let i = 0;
    while (i < intervals.length && intervals[i][1] < newInterval[0]) {
        res.push(intervals[i])
        i++;
    };
    while (i < intervals.length && intervals[i][0] <= newInterval[1]) {
        newInterval[0] = Math.min(newInterval[0], intervals[i][0]);
        newInterval[1] = Math.max(newInterval[1], intervals[i][1]);
        i++;
    };
    res.push(newInterval);
    while (i < intervals.length) {
        res.push(intervals[i]);
        i++;
    };
    return res;
};