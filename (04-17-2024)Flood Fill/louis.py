class Solution(object):
    def floodFill(self, image, sr, sc, color):
        """
        :type image: List[List[int]]
        :type sr: int
        :type sc: int
        :type color: int
        :rtype: List[List[int]]
        """
        from collections import deque
        if not image or image[sr][sc] == color:
            return image 
            
        ROW, COL = len(image), len(image[0])
        origin_color = image[sr][sc]
        que = deque([(sr, sc)])

        while que:
            r, c = que.popleft()
            image[r][c] = color

            for dr, dc in [(1, 0), (-1, 0), (0, 1), (0, -1)]:
                nr, nc = r + dr,  c + dc 
                if 0 <= nr < ROW and 0 <= nc < COL and image[nr][nc] == origin_color:
                    que.append((nr, nc))

        return image  
                