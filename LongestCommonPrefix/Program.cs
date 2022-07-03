using System;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "abcc","abcc","abcb" };
            string r = LongestCommonPrefix(strs);
            Console.WriteLine("Hello World!" + r);
        }

        public static string LongestCommonPrefix(string[] strs)
        {

            if (strs.Length == 1)
                return strs[0];
            string maxs = "";

            for (int i = 0; i < strs.Length - 1; i++)
            {
                string tempmax = "";
                if (i == 0)
                    maxs = strs[0];
                //for (int j = 0; j < strs[i].Length && j < strs[i + 1].Length && strs[i][j] == strs[i + 1][j]; j++)
                //{ 
                //    tempmax += strs[i][j];
                //}
                string s1 = strs[i];
                string s2 = strs[i + 1];
                if (s1 == s2) {
                    if (maxs.Length > s1.Length)
                        maxs = s1;
                    continue;
                }
                int l1 = s1.Length;
                int l2 = s2.Length;
                string smaller = l1 < l2 ? s1 : s2;
                int sl = smaller.Length;
                bool mached = false;

                while (sl > 0 && sl<= smaller.Length)
                {
                    string sub1 = s1.Substring(0, sl);
                    string sub2 = s2.Substring(0, sl);
                    if (sub1 == sub2)
                    {
                        tempmax = sub1;
                        mached = true;
                    }
                    if (mached && sub1 != sub2)
                        break;
                    if (mached) {
                        sl++;
                    }
                    else
                    {
                        int rem = sl > 2 ? sl % 2 : 0;
                        sl = rem + sl / 2;
                    }
                }

                if (tempmax == "")
                    return "";
               

                if (maxs.Length > tempmax.Length)
                    maxs = tempmax;
            }
            return maxs;
        }
    }
}

