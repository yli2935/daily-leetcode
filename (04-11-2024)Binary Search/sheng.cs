
namespace BinarySearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-1, 0, 3, 5, 9, 12];
            int target = 9;
            int res = Search(nums, target);
            Console.WriteLine(res);

        }
        public static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            return BinarySearch(nums, target, start, end);



        }
        private static int BinarySearch(int[] nums, int target, int start, int end)
        {
            if (start > end)
            {
                return -1;
            }
            else
            {
                int mid = (start + end) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                else if (nums[mid] > target)
                {
                    end = mid - 1;
                    return BinarySearch(nums, target, start, end);
                }
                else
                {
                    start = mid + 1;
                    return BinarySearch(nums, target, start, end);
                }

            }

        }

    }
}