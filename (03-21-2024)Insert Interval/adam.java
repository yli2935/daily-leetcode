/*
 * @Description: temp
 */
class Solution {
    public int[][] insert(int[][] intervals, int[] newInterval) {
        List<int[]> mergedIntervals = new LinkedList<>();
        for(int[] interval:intervals){
            if(interval[1] < newInterval[0]){
                mergedIntervals.add(interval);
            }else if(interval[0] > newInterval[1]){
                mergedIntervals.add(newInterval);
                newInterval = interval;
            }else{
                newInterval[0] = Math.min(newInterval[0], interval[0]);
                newInterval[1] = Math.max(newInterval[1], interval[1]);

            }

        }
        mergedIntervals.add(newInterval);
        return mergedIntervals.toArray(new int[mergedIntervals.size()][2]);



    }

}