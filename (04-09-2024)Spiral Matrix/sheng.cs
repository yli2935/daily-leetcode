
namespace SpiralMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = [[1, 2, 3, 4], [5, 6, 7, 8], [9, 10, 11, 12]];
            int[] res = SpiralMatrix(matrix);
            foreach(int x in res)
            {
                Console.Write(x+ " ");
            }
        }

        private static int[] SpiralMatrix(int[][] matrix)
        {
            int startX = 0;
            int startY = 0;
            int width = matrix[0].Length-1;
            int hight= matrix.Length-1;
            List<int> result = new List<int>();
            int count= 0;
            int i,j;
            //start
            Direction direction = Direction.Right;
            i = startY;
            j = startX;
            startY++;
            while (count< matrix.Length * matrix[0].Length) {
                
                //put the item into the list
                result.Add(matrix[i][j]);
                count++;
                //check direction
                if(direction==Direction.Right && j<width)
                {
                    j++;
                }
                //arrive the right top
                else if(direction == Direction.Right && j==width) {
               
                    direction = Direction.Down;
                    i++;
                    width--;
                }else if(direction==Direction.Down && i <hight) {
                    i++;
                }else if (direction==Direction.Down && i==hight)
                {
                    direction = Direction.Left;
                    j--;
                    hight--;
                    
                }else if(direction==Direction.Left && j > startX)
                {j--;

                }else if(direction==Direction.Left && j == startX)
                {
                    direction = Direction.Up;
                    i--;
                    startX++;

                }else if((direction==Direction.Up && i > startY  ))
                {
                    i--;
                }else if((direction==Direction.Up && i == startY))
                {
                    direction = Direction.Right;
                    j++;
                    startY++;
                }




            }
            return result.ToArray();
        }
        enum Direction
        {
            Right,
            Down,
            Left,
            Up,


        }
    }
}
