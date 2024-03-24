
class Solution {
/*
 * author:adam
 * 总体思路是三指针，i，j，k。只要nums[i] + nums[j] + nums[k] == target就记录ijk的值
 * 
 * 1. 先申请一个数据存放结果，并且将数组排序，因为只有排序之后才能控制kj两个指针移动
 * 2. 申请一个set，因为每次遍历会导致重复元素出现。
 * 3. 在 for(int i = 0;i<nums.length;i++) 中先固定一个i的值，然后再看另两个指针
 * 4. 每次循环中设置j = i + 1，k = nums.length - 1，这样就定了三个指针的位置
 * 5. 移动指针的规则是当target小于sum的时候，移动右边的指针，这样就会让sum变小，同理如果target大于sum，就移动左指针，让sum变大
 * 6. 最后将set加入到list中，并返回
 * 
 *  
 *  -4,-1,-1,0,1,2
 *   i  j        k  因为sum = -4 + (-1) +（2）= -3小于target 0，所以移动左指针
 * 
 *  -4,-1,-1,0,1,2
 *   i     j     k  因为sum = -4 + (-1) +（2）= -3小于target 0，所以移动左指针
 *        .
 *        .
 *        .
 *  -4,-1,-1,0,1,2
 *      i  j     k  第二次for循环的之后，此时的ijk的值就可以放入到set中
 * 
 */
    
    public List<List<Integer>> threeSum(int[] nums) {
        List<List<Integer>> ans = new ArrayList<>();
        int target = 0;
        Arrays.sort(nums);
        Set<List<Integer>> set = new HashSet<>();
        for(int i = 0;i<nums.length;i++){
            int j = i + 1;
            int k = nums.length - 1;
            while(j<k){
                int sum = nums[i] + nums[j] + nums[k];
                if(sum == target){
                    set.add(Arrays.asList(nums[i], nums[j], nums[k]));
                    k--;
                    j++;
                }else if(sum > target){
                    k--;
                }else{
                    j++;
                }
            }
            
        }
        ans.addAll(set);
        return ans;
        





    }

}