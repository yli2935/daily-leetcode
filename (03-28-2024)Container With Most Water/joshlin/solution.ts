function maxArea(height: number[]): number {
    let [l, r] = [0 , height.length - 1];
    let res = 0;
    while (l < r) {
        res = Math.max(res, Math.min(height[l], height[r]) * (r - l));
        if (height[l] < height[r]) l++; else r--;
    }
    return res;
};