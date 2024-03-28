class Solution {
    public int maxArea(int[] height) {
        int n = height.length;
        int p0 = 0;
        int p1 = n-1;
        int max = Math.min(height[p0], height[p1])*(p1-p0);

        while (p0 < p1) {
            if (height[p0] < height[p1]) {
                p0++;
            } else {
                p1--;
            }
            max = Math.max(max, Math.min(height[p0], height[p1])*(p1-p0));
        }

        return max;
    }
}
