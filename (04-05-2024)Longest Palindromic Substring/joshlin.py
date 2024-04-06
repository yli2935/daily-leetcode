class Solution:
    # Solution 1.1: Expanding strings from the center
    def longestPalindrome(self, s: str) -> str:
        res = s[0]
        # Length is Odd
        for i in range(1, len(s)):
            for j in range(1, min(i, len(s) - 1 - i) + 1):
                if s[i - j] != s[i + j]:
                    break
                if j * 2 + 1 > len(res):
                    res = s[i - j: i + j + 1]
        # Length is Even
        for i in range(len(s) - 1):
            for j in range(min(i, len(s) - 1 - i - 1) + 1):
                if s[i - j] != s[i + j + 1]:
                    break
                if j * 2 + 2 > len(res):
                    res = s[i - j: i + j + 1 + 1]
        return res

    # Solution 1.2: Expanding strings from the center using while loop
    def expand(self, s:str, left: int, right: int):
        while left >= 0 and right < len(s) and s[left] == s[right]:
            left  -= 1
            right += 1
        return s[left + 1: right]
    def longestPalindrome(self, s: str) -> str:
        res = ""
        for i in range(len(s)):
            # Odd -> self.expand(s, i, i), Even -> self.expand(s, i, i + 1)
            res = max(self.expand(s, i, i), self.expand(s, i, i + 1), res, key=len)
        return res

    # Solution 2.1: Dynamic Programming, checking substrings dp[l + 1][r - 1]
    def longestPalindrome(self, s: str) -> str:
        size = len(s)
        if size == 1: return s
        res = s[0]
        dp: List[List[bool]] = [[False for _ in range(size)] for _ in range(size)]

        for r in range(size):
            for l in range(r):
                if s[l] == s[r] and (r - l <= 2 or dp[l + 1][r - 1]):
                    dp[l][r] = True
                    if r - l + 1 > len(res):
                        res = s[l: r + 1]
        return res
