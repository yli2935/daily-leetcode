/*
 * @Description: temp
 */
class Solution {
    public int[] productExceptSelf(int[] nums) {
        int n = nums.length;
        int ans[] = new int[n];
        int head[] = new int[n];
        head[0] = 1;
        int tail[] = new int[n];
        tail[n - 1] = 1;

        for(int i = 1;i<n;i++){
            head[i] = head[i - 1] * nums[i - 1];
        }

        for(int i = n - 2;i>=0;i--){
            tail[i] = tail[i + 1] * nums[i + 1];
        }
        for(int i = 0;i<n;i++){
            ans[i] = head[i] * tail[i];
        }
        return ans;
    }

}