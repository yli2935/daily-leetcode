class Solution(object):
    def containsDuplicate(self, nums):
        duplicate = set()

        for num in nums:
            if num in duplicate:
                return True
            duplicate.add(num)

            
        return False 