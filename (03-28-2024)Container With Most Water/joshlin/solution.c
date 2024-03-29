int maxArea(int* height, int heightSize) {
    int l = 0, r = heightSize - 1, res = 0;
    while (l < r) {
        int area = (r - l) * (height[l] <= height[r] ? height[l] : height[r]);
        res = area >= res ? area : res;
        if (height[l] < height[r]) l++; else r--;
    }
    return res;
}