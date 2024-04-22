class Solution(object):
    def updateMatrix(self, mat):
        """
        :type mat: List[List[int]]
        :rtype: List[List[int]]
        """
        ROW = len(mat)
        COL = len(mat[0])
        dist = [[float('inf')] * COL for _ in range(ROW)]

        from collections import deque 
        que = deque()

        for r in range(ROW):
            for c in range(COL):
                if mat[r][c] == 0:
                    que.append((r, c))
                    dist[r][c] = 0 
        DIRECTION = [(1, 0), (-1, 0), (0, -1), (0, 1)]
        while que:
            r, c = que.popleft()

            for dr, dc in DIRECTION:
                nr, nc = r + dr, c + dc 

                if 0 <= nr < ROW and 0 <= nc < COL:
                    # find non-zero point 
                    if dist[nr][nc] > dist[r][c] + 1:
                        dist[nr][nc] = dist[r][c] + 1 
                        que.append((nr, nc))
        return dist
