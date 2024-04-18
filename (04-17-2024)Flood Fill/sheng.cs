using static System.Net.Mime.MediaTypeNames;

namespace FloodFill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] image = [[0,0,0], [0,1,1]];
            int sr = 1, sc = 1, newColor = 1;
            int[][] res = FloodFill(image, sr, sc, newColor);
            foreach (var row in res)
            {
                Console.Write("[");
                foreach (var i in row)
                {
                    Console.Write(i + ",");
                }
                Console.Write("]");
            }
        }

        private static int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
           
            if (image[sr][sc] == color)
            {
                return image;
            }
            Stack<(int,int)> stack = new Stack<(int,int)> ();
            var originalColor = image[sr][sc];
            stack.Push((sr, sc));
            while (stack.Count>0) {
                var point = stack.Pop();
                image[point.Item1][point.Item2] = color;
                sr=point.Item1; sc= point.Item2;
                int left = sc- 1;
                int right = sc + 1;
                int up = sr - 1;
                int down = sr + 1;
                if (left>=0 && image[sr][left] == originalColor)
                {
                    stack.Push((sr,left));
                }
                if(up>=0 && image[up][sc] == originalColor)
                {
                    stack.Push((up,sc));
                }
                if (down < image.Length && image[down][sc] == originalColor)
                {stack.Push((down,sc));
                }
                if (right < image[0].Length && image[sr][right] == originalColor)
                {
                    stack.Push((sr,right));
                }
            
            }
            return image;
        }
    }
}
