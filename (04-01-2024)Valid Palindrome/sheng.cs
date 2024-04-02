
namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "race a car";
            bool res = ValidPalindrome(s);
            Console.WriteLine(res);
        }

        private static bool ValidPalindrome(string s)
        {   s=s.ToLower();
            int start = 0;
            int end = s.Length-1;
            bool res = true;
            while (start <= end)
            {
                if (!Char.IsLetterOrDigit(s[start]))
                {
                    start++;
                    continue;
                }
                if (!Char.IsLetterOrDigit(s[end]))
                {
                    end--;
                    continue;
                }

                if (s[start] == s[end])
                {
                    start++;
                    end--;
                }
                else
                {
                    res = false;
                    break;
                }
            }
            return res;
        }
    }
}
