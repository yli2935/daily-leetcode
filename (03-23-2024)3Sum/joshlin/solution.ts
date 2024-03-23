function threeSum(nums: number[]): number[][] {
    nums = nums.sort((a, b) => a - b);
    const res: number[][] = [];
    for (let i = 0; i < nums.length; i++) {
        if (nums[i] > 0) break;
        if (i > 0 && nums[i - 1] == nums[i]) continue;
        let l = i + 1;
        let r = nums.length - 1;
        while (l < r) {
            let target = nums[i] + nums[l] + nums[r];
            if (target > 0) {
                r -= 1;
            } else if (target < 0) {
                l += 1;
            } else {
                res.push([nums[i], nums[l], nums[r]]);
                while (l < r && nums[l + 1] == nums[l]) l += 1;
                while (l < r && nums[r - 1] == nums[r]) r -= 1;
                l += 1;
                r -= 1;
            };
            
        };
    };
    return res;
};