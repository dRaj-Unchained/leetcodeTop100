using System;

namespace LongestPalindromicSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
           string ab= LongestPalindrome("acakk");
            Console.WriteLine("Hello World!");
        }

        public static string LongestPalindrome(string s)
        {
            int len = s.Length;
            int rlen = 0;
            string res = "";
            for (int i = 0; i < len; i++)
            {
                int l = i, r = i;

                while (l >= 0 && r < len && s[l] == s[r])
                {
                    if (rlen < r - l + 1)
                    {
                        rlen = r - l + 1;
                        res = s.Substring(l, rlen);
                    }
                    l--;
                    r++;
                }

                l = i;
                r = i+1;

                while (l >= 0 && r < len && s[l] == s[r])
                {
                    if (rlen < r - l + 1)
                    {
                        rlen = r - l + 1;
                        res = s.Substring(l, rlen);
                    }
                    l--;
                    r++;
                }
            }

            return res;
        }
    }
}
