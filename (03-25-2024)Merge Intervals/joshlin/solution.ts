function merge(intervals: number[][]): number[][] {
    intervals = intervals.map<number []>(a => [...a]).sort((a, b) => a[0] - b[0]);
    const res: number[][] = [];
    for (let i = 0; i < intervals.length; i++) {
        if (res.length != 0 && res[res.length-1][1] >= intervals[i][0]) {
            res[res.length-1][1] = Math.max(res[res.length-1][1], intervals[i][1]);
        } else {
            res.push(intervals[i]);
        };
    };
    return res;
};