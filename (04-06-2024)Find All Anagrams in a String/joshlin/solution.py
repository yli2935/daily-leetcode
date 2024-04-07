from collections import Counter
from typing import List

class Solution:
    def findAnagrams(self, s: str, p: str) -> List[int]:
        sSize, pSize = len(s), len(p)
        if pSize > sSize: return []
        sCount, pCount = Counter(s[:pSize]), Counter(p)
        left, right = 0, pSize - 1
        res = []
        while right < sSize:
            if sCount == pCount:
                res.append(left)
            if sCount[s[left]] > 1:
                sCount[s[left]] -= 1
            else:
                del sCount[s[left]]
            left += 1
            right += 1
            if right < sSize:
                sCount[s[right]] = sCount.get(s[right], 0) + 1
        return res