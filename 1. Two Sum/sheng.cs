using System;

namespace TwoSum

{
     class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = [2, 2];
            int target = 4;        
            int[] result = AddTwoSum2(numbers, target);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }

        }

        static int[] AddTwoSumBrouteForce(int[] nums, int target)
        {
            int[] tempary= new int[2];
            bool isFound = false;
            for (int i =0; i < nums.Length-1; i++) {
                for(int j=i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        tempary[0]= i;
                        tempary[1] = j;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
                 }
            return tempary;

        }

        static int[] AddTwoSum2(int[] nums, int target)
        {
            Dictionary<int, int> map = [];

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    return [map[(target - nums[i])], i];
                }
                else
                {
                    map[nums[i]]= i;
                }
            }
            return [] ;
        }
    }
}
