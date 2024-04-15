
namespace SearchInRotatedSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [3,1]; int target = 1;
            int res =Search(nums, target);
            Console.WriteLine(res);
        }

        private static int Search(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;
            while(start <= end)
            { 
                int mid= start +(end - start)/2;
              
                if (nums[mid] == target)
                { return mid; }

                if (nums[start] <= nums[mid])
                {
                    if (nums[start] <= target && target < nums[mid])
                        end = mid - 1;
                    else start = mid + 1;
                }
                else
                {
                    if (nums[mid] <target && target <= nums[end])
                    {
                        start= mid + 1;
                    }
                    else
                    {
                        end = mid - 1;
                    }
                }


              
            }
           
                return -1;
            
        }
    }
}
