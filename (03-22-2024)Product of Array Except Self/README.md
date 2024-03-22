<!--
 * @Description: temp
-->
# 238. Product of Array Except Self
### portal: [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/description/)
## Problem Description

Given an integer array `nums`, return an array `answer` such that `answer[i]` is equal to the product of all the elements of `nums` except `nums[i]`.

The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.

You must write an algorithm that runs in `O(n)` time and without using the division operation.

**Examples:**

```plaintext
Example 1:
Input: nums = [1,2,3,4]
Output: [24,12,8,6]
Explanation: 
- For `answer[0]`: the product of all elements before index 0 is 1, and the product of all elements after index 0 is 2 * 3 * 4 = 24.
- For `answer[1]`: the product of all elements before index 1 is 1, and the product of all elements after index 1 is 1 * 3 * 4 = 12.
- For `answer[2]`: the product of all elements before index 2 is 1 * 2, and the product of all elements after index 2 is 3 * 4 = 12.
- For `answer[3]`: the product of all elements before index 3 is 1 * 2 * 3, and the product of all elements after index 3 is 4.
```

**Constraints:**

- `2 <= nums.length <= 10^5`
- `-30 <= nums[i] <= 30`
- The product of any prefix or suffix of `nums` is guaranteed to fit in a 32-bit integer.
