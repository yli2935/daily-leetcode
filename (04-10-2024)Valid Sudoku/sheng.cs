using System.ComponentModel.Design;

namespace ValidateSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board = [['5','3','.','.','7','.','.','.','.']
,['6','.','.','1','9','5','.','.','.']
,['.','9','8','.','.','.','.','6','.']
,['8','.','.','.','6','.','.','.','3']
,['4','.','.','8','.','3','.','.','1']
,['7','.','.','.','2','.','.','.','6']
,['.','6','.','.','.','.','2','8','.']
,['.','.','.','4','1','9','.','.','5']
,['.','.','.','.','8','.','.','7','9']];
            bool res = ValidateSudoku(board);
            Console.WriteLine(res);
        }

        private static bool ValidateSudoku(char[][] board)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 1; i <= 9; i++)
            {
                map[i] = 0;
            }
            Dictionary<int, int>[,] dicts = new Dictionary<int, int>[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dicts[i, j] = new( map);
                }
            }
            Dictionary<int, int>[] dictHorizontal = new Dictionary<int, int>[board.Length];
            Dictionary<int, int>[] dictVertical = new Dictionary<int, int>[board.Length];
            for (int i = 0; i < 9; i++)
            {
                dictHorizontal[i] = new(map);
                dictVertical[i] = new(map);
            }

            int x = 0;
            while (x < board.Length)
            {
                int y = 0;
                while (y < board[x].Length)
                {
                    if (int.TryParse(board[x][y].ToString(), out int number))
                    {


                        dicts[x / 3, y / 3][number]++;
                        dictHorizontal[x][number]++;
                        dictVertical[y][number]++;
                        if(dicts[x / 3, y / 3][number]>1 || dictHorizontal[x][number]>1 || dictVertical[y][number] > 1)
                        {
                            return false;
                        }

                    }
                    y++;

                }
                x++;
            }
            return true;

        }
    }
}
