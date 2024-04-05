class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        l, res = 0, 0
        subString = set()
        for r in range(len(s)):
            while s[r] in subString:
                subString.remove(s[l])
                l += 1
            subString.add(s[r])
            res = max(res, r - l + 1)
        return res