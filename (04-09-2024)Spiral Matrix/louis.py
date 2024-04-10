class Solution(object):
    def spiralOrder(self, matrix):
        """
        :type matrix: List[List[int]]
        :rtype: List[int]
        """
        # have row and col and 4 pointers 
        ROW = len(matrix)
        COL = len(matrix[0])
        res = []
        LEFT, TOP, BOTTOM, RIGHT = 0, 0, ROW - 1, COL - 1

        while len(res) < ROW * COL:
            for i in range(LEFT, RIGHT + 1):
                res.append(matrix[TOP][i])
            TOP += 1
            
            for i in range(TOP, BOTTOM + 1):
                res.append(matrix[i][RIGHT])
            RIGHT -= 1
            
            if TOP <= BOTTOM:
                for i in range(RIGHT, LEFT - 1, -1):
                    res.append(matrix[BOTTOM][i])
                BOTTOM -= 1
            if LEFT <= RIGHT:
                for i in range(BOTTOM, TOP -1, -1):
                    res.append(matrix[i][LEFT])
                LEFT += 1
        return res 
