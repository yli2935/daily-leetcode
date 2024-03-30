class Solution {
    public int canCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.length;
        int start = 0;
        // i is the counter starts at start
        int i = 0;
        int tank = gas[0];
        while (true) {
            tank = tank - cost[i % n];
            if (tank < 0) {
                //since we choose start from 0 to n, if (i + 1) % n <= start, 
                // then the i+1th station must has been considered before, 
                //  this means that we have considered all stations and no one works
                if ((i + 1) % n <= start) {
                    return -1;
                } else {
                    start = (i + 1) % n;
                    i = start;
                    tank = gas[start];
                    continue;
                }
            } else {
                // a loop is complete and the tank still has gas left, so return start
                if ((i + 1) % n == start) {
                    return start;
                }
            }
            //update tank and i
            tank = tank + gas[(i + 1) % n];
            i++;
        }
    }
}
