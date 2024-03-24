/*
 * author:adam
 * 总体思路是按树的递归来走。下面讲解中的example使用candidates = [2,3,6,7], target = 7
 * 1. 先创建一个结果list ans，进入递归backtrack函数。
 * 2. 在递归函数中，结束的条件为，当target小于0，或者等于0
 *      2.1 当target小于0说明list中添加的元素和超过了target，这样直接return就可以
 *      2.2 如果等于0.说明list中的元素和正好等于taret，这时需要创建一个新的ArrayList进行深拷贝，因为在后续递归中会改变list，所以要深拷贝后放入结果list
 * 3. 然后进行一个for循环，这里的i是上一层递归传入的start，这是为了只会向传入start的前面走，而不会倒退，产生将[2,2,3]和[2,3,2]都放入结果列表中的情况
 * 4. 再每次循环中先把当前candidates[i]放入list中，然后进行递归，递归中target变为target - candidates[i]，start变为i
 * 5. 在 list.remove 中，是为了去除不是答案，但是已经放入list中的数字，例如：
 *    在刚开始循环的时候，start一直等于0，所以会一直进入backtrack递归，递归到第三次，target等于7 - 2 - 2 - 2 - 2 = -1
 *    已经小于0了跳出递归函数，这时list中是[2,2,2,2]，这显然不是答案，在返回后需要remove最后一个，变为[2,2,2]
 *    然后再进入下一次循环，这时i = 1，会将3放入list中，然后进入backtrack递归，发现还是小于0，然后返回后remove 3
 *    这样一直循环，以此类推，等到循环结束，返回，remove最后一个元素2，这样list就为[2,2]，
 *    再进入循环，以此类推。
 * 
 */
class Solution {
    int[] candidates;
    int target;
    public List<List<Integer>> combinationSum(int[] candidates, int target) {
        this.candidates = candidates;
        this.target = target;
        List<List<Integer>> ans = new ArrayList();
        backtrack(ans, new ArrayList<>(), target, 0);
        return ans;
    }

    public void backtrack(List<List<Integer>> ans,List<Integer> list,int target, int start){
        if(target < 0) return;
        if(target == 0){
            ans.add(new ArrayList(list));
            return;
        }
        for(int i = start;i<candidates.length;i++){
            list.add(candidates[i]);
            backtrack(ans, list, target - candidates[i], i);
            list.remove(list.size() - 1);

        }
        
    }
}