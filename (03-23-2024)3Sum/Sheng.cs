
using System.Globalization;

namespace _3Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-1, 0, 1, 2, -1, -4];
            int[][] res = ThreeSum(nums);
        }

        //Sort first and classify situation base on the 0
        private static int[][] ThreeSum(int[] nums)
        {
            //validate nums 
            if (nums == null || nums.Length <3)
            {
                return [];
            }

            List<int[]> temp = new List<int[]>();
           
            int zeros = 0;
            Dictionary<int,int> lessThanZero = new Dictionary<int,int>();
            Dictionary<int,int> largerThanZero= new Dictionary<int,int>();
          
           
            List<int> lessThanZeroArray= new ();
            List<int> largerThanZeroArray= new ();


            for (int i = 0; i < nums.Length; i++)
            {
              
                if (nums[i] == 0)
                {
                    zeros++;
                }
                if (nums[i] > 0)
                {

                    if (!largerThanZero.ContainsKey(nums[i]))
                    {
                        largerThanZero[nums[i]] = 1;
                        largerThanZeroArray.Add(nums[i]);
                    }
                    else if (largerThanZero[nums[i]] == 1)
                    {
                        largerThanZero[nums[i]]++;
                        largerThanZeroArray.Add(nums[i]);
                    }
                    //We do not need to care about more than 2 situation.
                    
                }
                if (nums[i] < 0)
                {
                    if (!lessThanZero.ContainsKey(nums[i]))
                    {
                        lessThanZero[nums[i]] = 1;
                        lessThanZeroArray.Add(nums[i]);
                    }
                    else if (lessThanZero[nums[i]] == 1)
                    {
                        lessThanZero[nums[i]]++;
                        lessThanZeroArray.Add(nums[i]);
                    }
                }
                
            }

            if (zeros>=3 ) {
                var temporaryTriplet = new int[] { 0, 0, 0 };
                temp.Add(temporaryTriplet);
            }
            //if there are 2 zeros, we consider it as 1 zero, the others shoud be one is less than 0, one is bigger than 0
            if(zeros==1 || zeros==2 )
            {
                foreach (var key in lessThanZero.Keys)
                {
                    if (largerThanZero.ContainsKey(0 - key))
                        {
                        var temporary = new int[] { 0, key,0-key };
                        temp.Add(temporary);
                    }
                }
            }
            //if no zero in the nums
          
                //two from right,one from left
                if (largerThanZeroArray.Count >= 2)
                {
                    //get two of the right
                    for(int i = 0;i < largerThanZeroArray.Count - 1;i++)
                    {
                        for (int j = i+1;j<largerThanZeroArray.Count; j++)
                        {
                            if (lessThanZero.ContainsKey(0 - largerThanZeroArray[j] - largerThanZeroArray[i]))
                            {
                                var temporary = new int[]
                                {
                                    largerThanZeroArray [j],largerThanZeroArray[i],0 - largerThanZeroArray[j] - largerThanZeroArray[i]
                                };
                                temp.Add(temporary);
                            }
                            
                        }
                    }
                }


                //find two from left, one from right
               
                if (lessThanZeroArray.Count >= 2)
                {
                    //get two of the right
                    for (int i = 0; i < lessThanZeroArray.Count - 1; i++)
                    {
                        for (int j = i + 1; j < lessThanZeroArray.Count; j++)
                        {
                            if (largerThanZero.ContainsKey(0 - lessThanZeroArray[j] - lessThanZeroArray[i]))
                            {
                                var temporary = new int[]
                                {
                                    lessThanZeroArray [j],lessThanZeroArray[i],0 - lessThanZeroArray[j] - lessThanZeroArray[i]
                                };
                                temp.Add(temporary);
                            }

                        }
                    }
                }


            return temp.ToArray();
        }
    }
}
