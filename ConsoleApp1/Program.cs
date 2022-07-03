using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = { 1,2,3,4,5,6};
            //int[] arr2 = { 7,8,9,10,11,12,13,14,15,0};

            //double rsl = 0.0;
            //rsl = FindMedianSortedArrays(arr1,arr2);
            //Console.WriteLine("Hello World!");

            string str = LongestPalindrome("babad");
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {

            int l1 = nums1.Length;

            int l2 = nums2.Length;
            int[] rslt = new int[l1 + l2];
            int index = 0;
            for (int i = 0; i < Math.Max(l1, l2); i++)
            {


                if (i < l1 && i < l2)
                {
                    if (nums1[i] < nums2[i])
                    {
                        rslt[index] = nums1[i];

                        index++;
                        rslt[index] = nums2[i];

                        index++;

                    }
                    else
                    {
                        rslt[index] = nums2[i];

                        index++;
                        rslt[index] = nums1[i];

                        index++;
                    }
                }
                else if (i >= l1)
                {
                    rslt[index] = nums2[i];

                    index++;
                }
                else if (i >= l2)
                {
                    rslt[index] = nums1[i];

                    index++;
                }


                if (index > 2 && rslt[index - 2] < rslt[index - 3])
                {
                    int tp = rslt[index - 2];
                    rslt[index - 2] = rslt[index - 3];
                    rslt[index - 3] = tp;
                }

                if (index > 1 && rslt[index - 1] < rslt[index - 2])
                {
                    int tp = rslt[index - 1];
                    rslt[index - 1] = rslt[index - 2];
                    rslt[index - 2] = tp;
                }

                if (index > 2 && rslt[index - 2] < rslt[index - 3])
                {
                    int tp = rslt[index - 2];
                    rslt[index - 2] = rslt[index - 3];
                    rslt[index - 3] = tp;
                }
            }
            for (int i = 0; i < rslt.Length; i++)
            {
                Console.Write(rslt[i]);
            }
            bool even = rslt.Length % 2 == 0;
            if (even == true)
            {

                return (float)(rslt[rslt.Length / 2] + rslt[rslt.Length / 2 - 1]) / 2;

            }
            else
            {
                return rslt[rslt.Length / 2];
            }
        }
        //public class Solution
        //{
        //    //public string LongestPalindrome(string s)
        //    //{
        //    //    string finalString = String.Empty;
        //    //    int size = 0;
        //    //    for (int i = 0; i < s.Length; i++)
        //    //    {
        //    //        for (int j = i; j < s.Length; j++)
        //    //        {
        //    //            if (s[i] == s[j])
        //    //            {
        //    //                string pal = CheckPal(s.Substring(i, j - i + 1));
        //    //                if (size < pal.Length)
        //    //                {
        //    //                    finalString = pal;
        //    //                    size = pal.Length;
        //    //                }
        //    //            }
        //    //        }
        //    //    }
        //    //    return finalString;
        //    //}
        //    //public static string CheckPal(string s)
        //    //{
        //    //    bool pal = true;
        //    //    int j = s.Length - 1;
        //    //    for (int i = 0; i < s.Length / 2; i++)
        //    //    {
        //    //        if (s[i] != s[j])
        //    //        {
        //    //            pal = false;
        //    //            break;
        //    //        }
        //    //        j--;
        //    //    }



        //    //    return pal ? s : "";
        //    //}
        //}

        //abcde
        public static string LongestPalindrome(string s)
        {
            string result = string.Empty;
            //int size = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //StringBuilder temp = new StringBuilder(s,i, s.Length-i,s.Length-i);
                //string temp = s.Substring(i,s.Length-i)
                //c.Remove(c.Length - 1, 1)
                for (int j = s.Length - 1; j >= i; j--)
                {

                    //temp += s[j];
                    //temp.Append(s[j]);
                    if (s[i] == s[j] )
                    {
                    string pal = isplm(s.Substring(i, j - i + 1));
                        if (!string.IsNullOrEmpty(pal)) {
                            if (result.Length < pal.Length) {
                                result = pal;
                            }
                            break;
                        }
                    }
                    //temp.Remove(j - i, 1);

                }

            }

            return result;
        }

        public static string isplm(string s)
        {

            for (int i = 0; i < s.Length - i; i++)
            {
                if (s[i] != s[s.Length - 1 - i])
                    return "";
            }

            return s;
        }
        public static bool CheckPal(string s)
        {
            bool pal = true;
            int j = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[j])
                {
                    pal = false;
                    break;
                }
                j--;
            }



            return pal;
        }


    }
}
