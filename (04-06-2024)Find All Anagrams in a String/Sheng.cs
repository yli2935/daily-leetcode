

namespace FindAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "cbaebabacd", p = "abc";
            int[] res = FindAnagramsBruteForce(s, p);
            foreach (int i in res)
            {
                Console.WriteLine(i);
            }
        }

        private static int[] FindAnagramsBruteForce(string s, string p)
        {
            List<int> res=[];
            int pLength=p.Length;
            char[] pArray = p.ToCharArray();
            Array.Sort(pArray);
            string newPstring =new(pArray);
            int i = 0;           
            int substringEnd = i + pLength - 1;

            while (substringEnd <s.Length)
            {
                if (!p.Contains(s[substringEnd]))
                {
                    i = substringEnd + 1;
                    substringEnd = i + pLength - 1;
                    continue;
                }

                bool isAnagram= CheckAnagram(s.Substring(i,pLength),newPstring);
                if (isAnagram)
                {
                    res.Add(i);
                }
                i++;
                substringEnd = i + pLength - 1;

            }
            return res.ToArray();

           
            
            
        }
        public static bool CheckAnagram(string str1, string str2)
        {
            char[] char1 = str1.ToLower().ToCharArray();         
            Array.Sort(char1);         
            string newStr1 = new string(char1);
            if (newStr1 == str2)
                return true;
            else
                return false;
        }
    }
}
