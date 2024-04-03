
namespace LongestSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "dvdf";
            int res = LongestSubstring(s);
            Console.WriteLine(res);
        }

        
        private static int LongestSubstring(string s)
        {
            int res = 0;
            
            if (s is null || s.Length==0)
            {
                return res;
            }
            Dictionary<char,int> keyValuePairs = [];
            for (int i = 0; i < s.Length; i++)
            {
                keyValuePairs.Add(s[i], 1);
                for (int j = i+1; j < s.Length; j++)
                {
                    if (keyValuePairs.ContainsKey(s[j]))
                    {
                        res = Math.Max(keyValuePairs.Keys.Count, res);
                        keyValuePairs = [];
                        break;
                    }
                    else
                    {
                        keyValuePairs.Add(s[j], 1);                    
                    }

                }
                res = Math.Max(keyValuePairs.Keys.Count, res);
                keyValuePairs = new Dictionary<char, int>();

            }
            
            return res;
        }
    }
}
