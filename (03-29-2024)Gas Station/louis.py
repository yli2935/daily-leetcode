class Solution(object):
    def canCompleteCircuit(self, gas, cost):
        """
        :type gas: List[int]
        :type cost: List[int]
        :rtype: int
        """
        # checking the ttlSum of gas and cost 
        if sum(gas) < sum(cost):
            return -1 
        
        ttl = 0 
        start = 0 

        for i in range(len(gas)):
            ttl += (gas[i] - cost[i])

            if ttl < 0:
                ttl = 0
                start = i + 1
        return start