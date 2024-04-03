
using System.Collections.Immutable;

namespace ValidAnagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "anagram", t = "nagaram";
            bool res= ValidAnagram(s,t);
            Console.WriteLine(res);
        }

        private static bool ValidAnagram(string s, string t)
        {
            bool res = true;
            if (s.Length!=t.Length)
            {
                res=false;
                return res;
            }
            char[]sArray = s.ToCharArray();
            Array.Sort(sArray);
            char[]tArray = t.ToCharArray();
            Array.Sort(tArray);
            for(int i = 0; i < sArray.Length; i++)
            {
                if (sArray[i] != tArray[i])
                {
                    res = false;
                   break;
                }
            }
            return res;
        }
    }
}
