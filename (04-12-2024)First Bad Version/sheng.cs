
namespace FirstBadVersion
{
    internal class Program
    {
        static int bad = 4;
        static void Main(string[] args)
        {
            int n = 5;
            

           

            int res = FindFirstBadVersion(n);
            Console.WriteLine(res);

        }

        private static int FindFirstBadVersion(int n)
        {
           
            int start = 1;
            int end = n;
            
            while (start < end)
            {
                int i = start + (end - start) / 2;
                if (!IsBadVersion(i)){
                    start = i + 1;

                }else
                {
                    end = i ;
                }
              
            }
            return start;
           
        }
       static bool IsBadVersion(int n)
        {
            return n>= bad;
        }

    }
}
