/*
 * @Description: temp
 */
class Solution {
    public int majorityElement(int[] nums) {
        HashMap<Integer,Integer> map = new HashMap<Integer,Integer>();
        for(int i = 0; i<nums.length;i++){
            if(map.containsKey(nums[i])){
                map.put(nums[i],map.get(nums[i])+1);
            }else{
                map.put(nums[i],1);
            }
        }
        int result = 0;
        int a = 0;
        for(int i = 0; i<nums.length;i++){
            if(map.get(nums[i]) > result){
                result = map.get(nums[i]);
                a = nums[i];
            }
        }
        return a;
        
    }
    // 因为majority的定义是超过数组length一半的元素，所以排序之后中间的一定是majority
    // 但是sort的时间复杂度是nlogn
    public int majorityElement(int[] nums) {
        Arrays.sort(nums);
        int n = nums.length;
        return nums[n/2];
    }

}