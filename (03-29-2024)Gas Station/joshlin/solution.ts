function canCompleteCircuit(gas: number[], cost: number[]): number {
  let [total, diff, start] = [0, 0, 0];
  for (let i = 0; i < gas.length; i++) {
      total += gas[i] - cost[i];
      diff += gas[i] - cost[i];
      if (diff < 0) {
          diff = 0;
          start = i + 1;
      }
  }
  return total >= 0 ? start : -1;
};