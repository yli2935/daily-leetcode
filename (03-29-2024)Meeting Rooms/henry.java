class Solution {
    public boolean canAttendMeetings(int[][] intervals) {
        Arrays.sort(intervals, (a,b) -> Integer.compare(a[0], b[0]));

        int begin = -1;
        int end = -1;
        for (int[] item : intervals) {
            begin = item[0];
            if (begin < end) {
                return false;
            }
            end = item[1];
        }

        return true;
    }
}
