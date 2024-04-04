class Solution(object):
    def lengthOfLongestSubstring(self, s):
        """
        :type s: str
        :rtype: int
        """
        # sliding window 
        check = set()
        start, end = 0, 0
        res = 0
        for end in range(len(s)):
            # meet the duplicates, shrink the left side, set left pointer += 1
            while s[end] in check:
                check.remove(s[start])
                start += 1
            check.add(s[end])

            res = max(end - start + 1, res)
        return res 