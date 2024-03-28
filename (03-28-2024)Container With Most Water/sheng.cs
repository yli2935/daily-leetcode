
namespace ContainerWithMostWater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] height = [1, 8, 6, 2, 5, 4, 8, 3, 7];
            int res = ContainerWithMostWaterBrouteForce(height);
            Console.WriteLine(res);
        }

        private static int ContainerWithMostWaterBrouteForce(int[] height)
        {
            int res = 0;
            for (int i = 0; i < height.Length - 1; i++)
            {
                for (int j = height.Length - 1; j > i; j--)
                {
                    if (height[j] >= height[i])
                    {
                        res = Math.Max(height[i] * (j - i), res);
                        break;
                    }

                }
            }
            for (int i = height.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (height[j] >= height[i])
                    {
                        res = Math.Max(height[i] * (i - j), res);
                        break;
                    }

                }
            }
            return res;
        }
        //Two pointers
        private static int MaxArea(int[] height)
        {
            int start = 0;
            int end = height.Length - 1;
            int max = Math.Min(height[start], height[end])*(end-start);
            while (start < end)
            {
                if (height[start] < height[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }
                max= Math.Max(max, Math.Min(height[start], height[end]) * (end - start));

            }
            return max;
        }
    }
}
