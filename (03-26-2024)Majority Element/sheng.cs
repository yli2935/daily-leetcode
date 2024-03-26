
namespace MajorityElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [2, 2, 1, 1, 1, 2, 2];
            int res = MajorityElement(nums);
            Console.WriteLine(res);
        }

        private static int MajorityElement(int[] nums)
        {
            Dictionary<int,int> map = new Dictionary<int,int>();
            
            if (nums.Length ==1) {
                
                return nums[0];
            }
            foreach(var num in nums)
            {
                if (!map.ContainsKey(num))
                {
                    map.Add(num, 1);
                }else
                {
                    map[num]++;
                    if (map[num] > nums.Length/2)
                    {
                      return num;
                       
                    }
                }
            }
            return 0;
            
        }
    }
}
