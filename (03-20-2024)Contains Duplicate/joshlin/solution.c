#include <stdlib.h>
#include <stdbool.h>

int comp(const void * elem1, const void * elem2) 
{
    int f = *((int*)elem1);
    int s = *((int*)elem2);

    if (f > s) return  1;
    if (f < s) return -1;

    return 0;
}

// time O(nlogn) space O(n)
// look for consecutive repeating numbers
bool containsDuplicate(int* nums, int numsSize)
{
    qsort(nums, numsSize, sizeof(*nums), comp);

    for (int i = 1; i < numsSize; i++)
    {
        if (nums[i - 1] == nums[i]) return true;
    }

    return false;
}