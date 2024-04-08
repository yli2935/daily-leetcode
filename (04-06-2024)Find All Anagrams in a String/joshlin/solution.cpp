#include <unordered_map>
#include <vector>
#include <string>

class Solution {
public:
    std::vector<int> findAnagrams(std::string s, std::string p) {
        int sSize = s.length(), pSize = p.length();
        std::unordered_map<char, int> sCount, pCount;
        for (int i = 0; i < pSize; i++) {
            sCount[s[i]]++;
            pCount[p[i]]++;
        }
        std::vector<int> res = sCount == pCount ? std::vector<int>{0} : std::vector<int>{};
        int left = 0;
        for (int right = pSize; right < sSize; right++) {
            sCount[s[left]]--;
            if (sCount[s[left]] == 0) sCount.erase(s[left]);
            sCount[s[right]]++;
            left++;
            if (sCount == pCount) res.push_back(left);
        }
        return res;
    }
};