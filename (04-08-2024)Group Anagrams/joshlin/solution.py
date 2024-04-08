from typing import List, Dict
from collections import defaultdict

class Solution:
    # m * nlogn
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        cache: Dict[str, List[str]] = defaultdict(list)
        for word in strs:
            group = ''.join(sorted(word))
            cache[group].append(word) 
        return list(cache.values())
    # m * n * 26
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
      """
      Instead of using `key = ''.join(sorted(s))`,
      lets create an array of character frequences as the key.
      And to make it a hashable key, we need to convert it to
      a tuple using `tuple()`
      """
      hashMap = defaultdict(list)
      for string in strs:
          key = [0] * 26
          # [0, 0, ..., 0]
          #  a, b, ..., z
          for char in string:
              index = ord(char) - ord('a')
              key[index] += 1
          key = tuple(key)
          hashMap[key].append(string)
      return hashMap.values()