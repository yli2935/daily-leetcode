
namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 2, 3, 0];
            bool result = ContainsDuplicate(nums);
            Console.WriteLine("result: "+result);
        }

        private static bool ContainsDuplicate(int[] nums)
        {
            Dictionary<int, int> dic = [];
            for(int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic[nums[i]] = i;
                }
                else
                {
                    return true;
                }
            }
           return false;
        }
    }
}
