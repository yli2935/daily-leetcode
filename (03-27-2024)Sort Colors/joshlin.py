class Solution:
    def sortColors(self, nums: List[int]) -> None:
        """
        Do not return anything, modify nums in-place instead.
        这题真tm难(╯°Д°)╯︵ ┻━┻，现实里遇到这种问题，我直接一个sort()完事儿
        此题属于Dutch National Flag Problem，时间O(n)空间O(1), 详见https://users.monash.edu/~lloyd/tildeAlgDS/Sort/Flag
        三个指针将array分为四个区域: [0s] [1s] [unknown] [2s]
        [0s] => [0..left-1], [1s] => [left..mid-1], [unknown] => [mid..right], [2s] => [right+1..N-1]
        我们的目标是在保持排序的同时，缩小unknown，那么最后得到的就是: [0s] [1s] [2s]
        """
        left, mid, right = 0, 0, len(nums) - 1
        while mid <= right:
            print(nums)
            if nums[mid] < 1:
                nums[left], nums[mid] = nums[mid], nums[left]
                left += 1
                mid  += 1
            elif nums[mid] > 1:
                nums[right], nums[mid] = nums[mid], nums[right]
                right -= 1
            else:
                mid += 1
