using System.Security.Cryptography.X509Certificates;

namespace LongestPalindromicSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ccc";
            string res = LongestPalindromicSubstring(s);
            Console.WriteLine(res);
        }

        private static string LongestPalindromicSubstring(string s)
        {

            int left = s.Length - 1;
            int right = 0;
            string res = "";
            int i = 0;
            string temp;
            //1.s[i] is the right center
            while (i < s.Length)
            {
                //from the first letter
                temp = s[i].ToString();
                left = i - 1;
                right = i + 1;
                while (left>=0 &&right < s.Length)
                {
                    // Console.WriteLine(temp);

                    if (s[left] == s[right])
                    {
                        temp = s[left--] + temp + s[right++];

                    }
                    else
                    {


                        break;
                    }

                }
                res = temp.Length > res.Length ? temp : res;
                i++;
            }
                   i = 0;
                //2. the s[i] is the center of left
                while (i < s.Length)
                {
                    //from the first letter
                    temp = s[i].ToString();
                    left = i - 1;
                    right = i + 1;
                    while (right < s.Length)
                    {

                        if (s[i] == s[right] && right == i + 1)
                        {
                            temp = temp + s[right++];
                        }
                        else if (left < 0)
                        {
                            break;
                        }
                        else if (s[left] == s[right])
                        {
                            temp = s[left--] + temp + s[right++];

                        }
                        else
                        {


                            break;
                        }
                    }
                    res = temp.Length > res.Length ? temp : res;


                    //  Console.WriteLine(res);
                    i++;


                }
                
                return res;
            }
        }
    }

