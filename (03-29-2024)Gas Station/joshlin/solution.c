int canCompleteCircuit(int* gas, int gasSize, int* cost, int costSize) {
    int start = 0, total = 0, diff = 0;
    for (int i = 0; i < gasSize; i++) {
        int currSurplus = gas[i] - cost[i];
        total += currSurplus;
        diff += currSurplus;
        if (diff < 0) {
            diff = 0;
            start = i + 1;
        }
    }
    return total >= 0 ? start : -1;
}