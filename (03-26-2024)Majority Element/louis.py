class Solution(object):
    def majorityElement(self, nums):
        count = {}

        for ele in nums:
            if ele in count:
                count[ele] += 1
            else:
                count[ele] = count.get(ele, 0) + 1
        highest_count = 0
        res = 0
        
        for ele, freq in count.items():
            if freq > highest_count:
                highest_count = freq
                res = ele 
        return res 
    # O(n)time and space

            