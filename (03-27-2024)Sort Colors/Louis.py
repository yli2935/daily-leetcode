class Solution(object):
    def sortColors(self, nums):
        """
        :type nums: List[int]
        :rtype: None Do not return anything, modify nums in-place instead.
        """
        #three pointers looping one, one for 0 another for 2 
        zeroPointer, currPointer = 0, 0 
        twoPointer = len(nums) - 1

        # shouldn't surpass Twopointer 
        while currPointer <= twoPointer:
            # finished on left side both increment
            if nums[currPointer] == 0:
                nums[zeroPointer], nums[currPointer] = nums[currPointer], nums[zeroPointer]
                zeroPointer += 1
                currPointer += 1
            # only finish on the tail, head pointer could still need adjust
            elif nums[currPointer] == 2:
                nums[twoPointer], nums[currPointer] = nums[currPointer], nums[twoPointer]
                twoPointer -= 1
            else:
                currPointer += 1
        return nums 