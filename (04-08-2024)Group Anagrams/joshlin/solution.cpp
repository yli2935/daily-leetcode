#include <unordered_map>
#include <vector>
#include <string>
#include <algorithm>

using namespace std;

class Solution {
public:
    vector<vector<string>> groupAnagrams(vector<string>& strs) {
        unordered_map<string, vector<string>> cache;
        vector<vector<string>> res;     
        for (const auto& word: strs) {
            string key = word;
            sort(key.begin(), key.end());
            cache[key].push_back(word);
        };
        for (const auto& [_, group]: cache) {
            res.push_back(group);
        };
        return res;
    };
};