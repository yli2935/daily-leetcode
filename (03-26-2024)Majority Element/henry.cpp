using namespace std;
#include <algorithm>
#include <array>
#include <iostream>
#include <unordered_map>
#include <utility>
#include <vector>

class Solution {
public:
    int majorityElement(vector<int>& nums) {
        unordered_map<int, int> map;
        int n = nums.size();
        int answer_count = INT_MIN;
        int answer = INT_MIN;
        for (int i = 0; i < n; i++) {
            map[nums[i]]++;
        }

        for (pair<int, int> item : map) {
            if (item.second > answer_count) {
                answer_count = item.second;
                answer = item.first;
            }
        }

        return answer;
    }
};