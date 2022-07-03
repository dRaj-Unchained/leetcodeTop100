using System;
using System.Collections.Generic;
using System.Linq;

namespace _36_ValidSudoku
{
    class Program
    {
        static void Main(string[] args)
        {

            //char[][] grid = { "GEEKSFORGEEKS".ToArray(),
            //      "GEEKSQUIZGEEK".ToArray(),
            //      "IDEQAPRACTICE".ToArray() };

            //char[][] grid = {
            //                "53..7....".ToArray()
            //                ,"6..195...".ToArray()
            //                ,".95....6.".ToArray()
            //                ,"8...6...3".ToArray()
            //                ,"4..8.3..1".ToArray()
            //                ,"7...2...6".ToArray()
            //                ,".6....28.".ToArray()
            //                ,"...419..5".ToArray()
            //                ,"....8..79".ToArray()};

            char[][] grid = { 
                "....5..1.".ToArray(),
                ".4.3.....".ToArray(),
                ".....3..1".ToArray(),
                "8......2.".ToArray(),
                "..2.7....".ToArray(),
                ".15......".ToArray(),
                ".....2...".ToArray(),
                ".2.9.....".ToArray(),
                "..4......".ToArray() };

            bool re = IsValidSudoku(grid);
            Console.WriteLine("Hello World!");
        }

        public static bool IsValidSudoku(char[][] board)
        {

            Dictionary<string, string> m1 = new Dictionary<string, string>();
            Dictionary<string, string> m2 = new Dictionary<string, string>();
            Dictionary<string, string> m3 = new Dictionary<string, string>();
            Dictionary<string, string> m4 = new Dictionary<string, string>();
            Dictionary<string, string> m5 = new Dictionary<string, string>();
            Dictionary<string, string> m6 = new Dictionary<string, string>();
            Dictionary<string, string> m7 = new Dictionary<string, string>();
            Dictionary<string, string> m8 = new Dictionary<string, string>();
            Dictionary<string, string> m9 = new Dictionary<string, string>();

            for (int i = 0; i < 9; i++)
            {
                Dictionary<string, string> h = new Dictionary<string, string>();
                Dictionary<string, string> v = new Dictionary<string, string>();

                for (int j = 0; j < 9; j++)
                {

                    string check_h = board[i][j].ToString();
                    string check_v = board[j][i].ToString();

                    if (h.ContainsKey(check_h))
                    {
                        return false;
                    }
                    else if (check_h != ".")
                    {
                        h.Add(check_h, check_h);
                    }

                    if (v.ContainsKey(check_v))
                    {
                        return false;
                    }
                    else if (check_v != ".")
                    {
                        v.Add(check_v, check_v);
                    }

                   
                    //first 
                    if (i < 3 && j < 3)
                    {
                        if (m1.ContainsKey(check_h))
                        {
                            return false;
                        }
 
                        if (check_h != ".")
                        {
                            m1.Add(check_h, check_h);
                        }
                    }
                    if (i >= 3 && i < 6 && j < 3)
                    {
                        if (m2.ContainsKey(check_h))
                        {
                            return false;
                        }

                        if (check_h != ".")
                        {
                            m2.Add(check_h, check_h);
                        }
                    }
                    if (i >= 6 && i < 9 && j < 3)
                    {
                        if (m3.ContainsKey(check_h))
                        {
                            return false;
                        }

                        if (check_h != ".")
                        {
                            m3.Add(check_h, check_h);
                        }
                    }

                    //second 
                    if (i < 3 && j >= 3 && j< 6)
                    {
                        if (m4.ContainsKey(check_h))
                        {
                            return false;
                        }

                        if (check_h != ".")
                        {
                            m4.Add(check_h, check_h);
                        }
                    }
                    if (i >= 3 && i < 6 && j >= 3 && j < 6)
                    {
                        if (m5.ContainsKey(check_h))
                        {
                            return false;
                        }

                        if (check_h != ".")
                        {
                            m5.Add(check_h, check_h);
                        }
                    }
                    if (i >= 6 && i < 9 && j >= 3 && j < 6)
                    {
                        if (m6.ContainsKey(check_h))
                        {
                            return false;
                        }

                        if (check_h != ".")
                        {
                            m6.Add(check_h, check_h);
                        }
                    }

                    // third
                    if (i < 3 && j >= 6 && j < 9)
                    {
                        if (m7.ContainsKey(check_h))
                        {
                            return false;
                        }

                        if (check_h != ".")
                        {
                            m7.Add(check_h, check_h);
                        }
                    }
                    if (i >= 3 && i < 6 && j >= 6 && j < 9)
                    {
                        if (m8.ContainsKey(check_h))
                        {
                            return false;
                        }

                        if (check_h != ".")
                        {
                            m8.Add(check_h, check_h);
                        }
                    }
                    if (i >= 6 && i < 9 && j >= 6 && j < 9)
                    {
                        if (m9.ContainsKey(check_h))
                        {
                            return false;
                        }

                        if (check_h != ".")
                        {
                            m9.Add(check_h, check_h);
                        }
                    }
                }


            }


            return true;
        }
    }
}
