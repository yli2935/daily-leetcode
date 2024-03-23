function productExceptSelf(nums: number[]): number[] {
    let left = 1;
    let right = 1;
    const res = Array<number>(nums.length).fill(1);
    for (let i = 1; i < nums.length; i++) {
        left *= nums[i - 1];
        res[i] = left;
    };
    for (let i = nums.length - 2; i >= 0; i--) {
        right  *= nums[i + 1];
        res[i] *= right;
    };
    return res;
};