class Solution(object):
    def longestPalindrome(self, s):
        """
        :type s: str
        :rtype: int
        """
        count = {}

        for ch in s:
            count[ch] = count.get(ch, 0) + 1
        
        res = 0
        oddOccur = False 

        for freq in count.values():
            if freq % 2 == 0:
                res += freq 
            else:
                # pair even occurance, left the odd at the end 
                res += freq - 1
                oddOccur = True 
        
        if oddOccur:
            res += 1
        return res 
            