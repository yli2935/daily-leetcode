
namespace LongestPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "abccccdd";
          int res = GetLongestPalindrome(s);
            Console.WriteLine(res);
        }

        private static int GetLongestPalindrome(string s)
        {
            int res = 0;
          
            Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (keyValuePairs.ContainsKey(s[i]))
                {
                    keyValuePairs.Remove(s[i]);
                    res++;
                }
                else
                {
                    keyValuePairs.Add(s[i], 1);
                    res++;
                }
            }
            if(keyValuePairs.Count >1) {
                res = res - keyValuePairs.Count + 1;
            }
            return res;
        }
    }
}
