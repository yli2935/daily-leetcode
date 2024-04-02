class Solution(object):
    def isAnagram(self, s, t):
        """
        :type s: str
        :type t: str
        :rtype: bool
        """
        counts = {}

        for l in s:
            if l  in counts:
                counts[l] += 1
            else:
                counts[l] = 1
        
        for r in t:
            if r in counts:
                counts[r] -=1 
                if counts[r] == 0: 
                    del counts[r]
            else:
                return False 
        
        if len(counts) > 0:return False 
        return True 