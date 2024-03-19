function twoSum(nums: number[], target: number): number[] {
    // time: O(n), space: O(n)
    let complement: {[key: number]: number} = {}
    for (const [index, num] of nums.entries()) {
        const diff = target - num
        if (diff in complement) {
            return [index, complement[diff]]
        } else {
            complement[num] = index
        }
    }
    return []
};