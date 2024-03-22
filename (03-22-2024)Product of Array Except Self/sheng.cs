
namespace Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [-1, 1, 0, -3, 3];
            int[] output = Product(nums);
            foreach (int i in output)
            {
                Console.WriteLine(i);
            }

        }

        private static int[] Product(int[] nums)
        {
            int productOfArray = 1;
            int[] res = new int[nums.Length];
            //need to check num[i] is 0 or not. 

            int count0 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    count0++;
                }
                else
                {
                    productOfArray *= nums[i];
                }

            }



            for (int i = 0; i < nums.Length; i++)
            {
                if (count0 == 0)
                {
                    res[i] = productOfArray / (nums[i]);

                }
                else if (count0 == 1 && nums[i] == 0)
                {
                    res[i] = productOfArray;
                }
                else
                {
                    res[i] = 0;

                }
            }


        }
           
           return res;
           
            

        }
}
}
