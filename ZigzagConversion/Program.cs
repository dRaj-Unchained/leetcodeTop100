using System;

namespace ZigzagConversion
{
    class Program
    {
        static void Main(string[] args)
        {

//            "PAYPALISHIRING"
//3
//"PAYPALISHIRING"
//4
//"A"
//1

            string s = "PAYPALISHIRING";
            int numRows = 4;
            string res = Convert(s, numRows);
            Console.WriteLine("Hello World!");
        }

        public static string Convert(string s, int numRows)
        {
            string res="";
            if (numRows == 1) {
                return s;
            }
            //for(int i=0; i< numRows; i++) {

            string[] ares = new string[numRows];

                int cl = 0;

                bool FF = true;

                for (int j = 0; j < s.Length; j++)
                {

                //if (cl == i)
                //{
                //    res += s[j];
                //}
                ares[cl] += s[j];
                    if (j != 0 && j % (numRows - 1) == 0)
                        FF = !FF;
                    if (FF)
                        cl++;
                    else
                        cl--;

                   
                }
            //}
            for (int k = 0; k < numRows; k++) {
                res += ares[k];
            }
            return res;
        }
    }
}
