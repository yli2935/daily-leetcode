
namespace SortColors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1,0];
            int[] res = SortColors(nums);
            foreach(int x in res)
            {
                Console.WriteLine(x);
            }

        }

        private static int[] SortColors(int[] nums)
        {
            
            int zero = 0;
            int one = 0;
            int two = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                  
                                     
                    if (two != 0 && one !=0)
                    {                    
                        nums[i] =2;
                        nums[zero+one] = 1;
                        
                    }
                    else if (two!=0 && one == 0){
                        nums[i] = 2;
                        
                    }else if(two ==0 && one != 0)
                    {
                        nums[i] = 1;
                    }

                    nums[zero++] = 0;



                }
               else if (nums[i] == 1) {
                    if (two != 0)
                    {
                        nums[i] = 2;
                    }
                    nums[zero+one] = 1;
                    one++;
                   
                }
               else if (nums[i] == 2)
                {                           
                    two++;
                }
            }
            return nums;
        }
    }
}
