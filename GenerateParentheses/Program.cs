using System;
using System.Collections.Generic;

namespace GenerateParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = GenerateParenthesis(6);
            Console.WriteLine("Hello World!");
        }

        public static IList<string> GenerateParenthesis(int n)
        {
            string inpit = "";
            List<string> output = new List<string>();
            List<string> outputall = new List<string>();
            while (n > 0)
            {
                inpit += "()";
                n--;
            }

            int N = inpit.Length;
            backtrack(inpit, 0, N - 1, ref outputall);
            //for (int k = 0; k < inpit.Length; k++)
            //{

            //for (int i = 0; i < inpit.Length; i++)
            //{
            //    string check = inpit[i].ToString();
            //    string inputcheck = inpit.Substring(0, i) + inpit.Substring(i + 1, inpit.Length - 1 - i);

            //    for (int j = 0; j < inpit.Length; j++)
            //    {

            //        string start = "";
            //        string mid = "";
            //        string end = "";
            //        start = inputcheck.Substring(0, j);
            //        mid = check;
            //        end = inputcheck.Substring(j, inputcheck.Length - j);
            //        //tempout = start + mid + end;
            //        string vald = start + mid + end;
            //        //if (IsValid(vald) && !output.Contains(vald))
            //        output.Add(vald);

            //    }
            //}
            //}
            return outputall;
        }
        public static String swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return string.Concat(charArray);
        }
        private static void backtrack(String s, int idx, int N, ref List<string> lst)
        {
            if (idx == N && IsValid(s) && !lst.Contains(s))
                lst.Add(s);
            else
            {
                for (int i = idx; i <= N; i++)
                {
                    s = swap(s, idx, i);
                    backtrack(s, idx + 1, N,ref lst);
                    s = swap(s, idx, i);
                }
            }
        }
        public static bool IsValid(string s)
        {
            if (s.Length == 0 || s.Length == 1 || s.Length % 2 == 1)
                return false;
            int copen = 0;
            int dopen = 0;
            int eopen = 0;
            string canclose = s[0].ToString();
            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case '(':
                        copen++;
                        canclose += ')';
                        break;
                    case ')':
                        if (s[i] != canclose[canclose.Length - 1])
                            return false;
                        copen--;
                        canclose = canclose.Substring(0, canclose.Length - 1);
                        break;
                    case '[':
                        dopen++;
                        canclose += ']';
                        break;
                    case ']':
                        if (s[i] != canclose[canclose.Length - 1])
                            return false;
                        canclose = canclose.Substring(0, canclose.Length - 1);
                        dopen--;
                        break;
                    case '{':
                        eopen++;
                        canclose += '}';
                        break;
                    case '}':
                        if (s[i] != canclose[canclose.Length - 1])
                            return false;
                        eopen--;
                        canclose = canclose.Substring(0, canclose.Length - 1);
                        break;
                    default:
                        break;
                }
                if (copen < 0 || dopen < 0 || eopen < 0)
                    return false;
            }
            if (copen == 0 && dopen == 0 && eopen == 0)
                return true;
            return false;
        }
    }
}
