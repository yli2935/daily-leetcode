class Solution:
    def longestPalindrome(self, s: str) -> int:
        freq = {}
        res = 0
        for c in s:
            freq[c] = freq.get(c, 0) + 1
        for count in freq.values():
            res += count // 2
        return res * 2 + (1 if len(s) > res * 2 else 0)