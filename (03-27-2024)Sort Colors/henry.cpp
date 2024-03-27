#include <vector>
#include <iostream>
#include <utility>
using namespace std;

// Use double pointer, p0 marks the position for the next potential 0, p1 marks the position for the next potential 1
// when swapping 0, if p1 > p0, 1 will definitely be swapped to the back, so need an extra swap of nums[i] and nums[p1]
// example: [0, 1, 1, 2, 2, 0] => [0, 0, 1, 2, 2, 1] => [0, 0, 1, 1, 2, 2]

class Solution {
public:
    void sortColors(vector<int>& nums) {
        int p0 = 0;
        int p1 = 0;
        int n = nums.size();

        for (int i = 0; i < n; i++) {
            if (nums[i] == 0) {
                swap(nums[i], nums[p0]);
                if (p0 < p1) {
                    swap(nums[i], nums[p1]);
                }
                p0++;
                p1++;
            } else if (nums[i] == 1) {
                swap(nums[i], nums[p1]);
                p1++;
            }
        }

    }
};