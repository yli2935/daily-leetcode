// time O(n) space O(n)
// !!! bad practice because it won't break even if the first two numbers are the same
function containsDuplicate3(nums: number[]): boolean {
    const numSet = new Set<number>(nums);
    return numSet.size < nums.length;
};

// time O(nlogn) space O(n)
// look for consecutive repeating numbers
function containsDuplicate0(nums: number[]): boolean {
    const sortedNums = [...nums];
    sortedNums.sort();
    for (const [index, num] of sortedNums.entries()) {
        if (index > 0 && sortedNums[index - 1] == num) return true;
    }
    return false;
};

// time O(n) space O(n)
// check if count of any num > 1
function containsDuplicate1(nums: number[]): boolean {
    const numObj = {};
    for (const num of nums) {
        numObj[num] = numObj[num] + 1 || 1;
        if (numObj[num] > 1) return true;
    }
    return false;
};

// time O(n) sapce O(n)
// check if current num matches any in the hashset
function containsDuplicate2(nums: number[]): boolean {
    const numSet = new Set();
    for (const num of nums) {
        if (numSet.has(num)) return true;
        numSet.add(num);
    }
    return false;
};

