using System;

namespace RomantoInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = RomanToInt("XCXL");
            Console.WriteLine("Hello World!" + r);
        }


        public static int RomanToInt(string s)
        {
            int[] n = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            String[] r = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            int res = 0;
            int curr = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string temp = "";
                if (i != s.Length - 1)
                {
                     temp = s[i].ToString() + s[i + 1].ToString();

                }
               

                bool pair = false;
                for (int j = 1; j < r.Length; j++, j++)
                {

                    if (r[j] == temp)
                    {
                        res += n[j];
                        pair = true;
                        break;
                    }
                }
                if (pair)
                {
                    i++;
                }
                else {
                    for (int j = 0; j < r.Length; j++, j++)
                    {
                        if (r[j] == s[i].ToString())
                        {
                            res += n[j];
                            break;
                        }
                    }
                }

            }
            return res;
        }
    }
}
