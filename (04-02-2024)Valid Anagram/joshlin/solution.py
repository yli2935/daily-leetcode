class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        frequency = {}
        for c in s:
            frequency[c] = frequency.get(c, 0) + 1
        for c in t:
            if c not in frequency:
                return False
            frequency[c] -= 1
        for count in frequency.values():
            if count != 0:
                return False
        return True