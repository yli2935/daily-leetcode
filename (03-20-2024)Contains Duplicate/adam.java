/*
 * @Description: temp
 */
class Solution {
    public boolean containsDuplicate(int[] nums) {
        if(nums == null || nums.length == 0) return false;
        Arrays.sort(nums); // nlongn
        int prev = nums[0];
        for(int i = 1;i<nums.length;i++){
            if(prev == nums[i]) return true;
            prev = nums[i];

        }
        return false;

    }

    // public boolean containsDuplicate(int[] nums) {

    //     HashSet<Integer> set = new HashSet<>();
    //     for (int i = 0; i < nums.length; i++) {
    //         if (set.contains(nums[i])) {
    //             return true;
    //         }
    //         set.add(nums[i]);
    //     }
    //     return false;
    // }
}