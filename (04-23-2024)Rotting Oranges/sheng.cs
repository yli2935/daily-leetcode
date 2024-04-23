
namespace RottingOranges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = [[2, 1, 1], [1, 1, 1], [0, 1, 2]];
            int res = OrangesRotting(grid);
            Console.WriteLine(res);
        }

        private static int OrangesRotting(int[][] grid)
        {
            int minute = 0;
            Queue<((int, int), int)> rottenOranges = [];
           
            int[][] directions = [[-1, 0], [1, 0], [0, -1], [0, 1]];
            int m = grid.Length;
            int n = grid[0].Length;

           
            //put current rotten oranges in the queque
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if ( grid[i][j] == 2)
                    {
                        rottenOranges.Enqueue(((i, j), minute));
                      
                    }
                }
            }
            while (rottenOranges.Count > 0)
            {
                var orange = rottenOranges.Dequeue();
                int x = orange.Item1.Item2;
                int y = orange.Item1.Item1;
                int temporaryMinute = orange.Item2;
                foreach (var direction in directions)
                {
                    int newX = x + direction[1];
                    int newY = y + direction[0];
                    if (newX >= 0 && newY >= 0 && newX < n && newY < m && grid[newY][newX] == 1)
                    {
                        grid[newY][newX] = 2;
                        rottenOranges.Enqueue(((newY, newX), temporaryMinute+1));
                     
                        minute = temporaryMinute+1;

                    }


                }

            }
            //check if there a fresh orange left
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        return -1;
                    }
                }
            }
            return minute;
        }
    }
}
