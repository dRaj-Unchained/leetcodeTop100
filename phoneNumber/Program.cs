using System;
using System.Collections.Generic;

namespace phoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = LetterCombinations("234");
            Console.WriteLine("Hello World!");
        }

        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> rs = new List<string>();
            Dictionary<int, List<string>> nums = new Dictionary<int, List<string>>()
                {
                { 2, new List<string>(){"a","b","c" } },
                { 3, new List<string>(){"d","e","f" } },
                { 4, new List<string>(){"g","h","i" } },
                { 5, new List<string>(){"j","k","l" } },
                { 6, new List<string>(){"m","n","o" } },
                { 7, new List<string>(){"p","q","r","s" } },
                { 8, new List<string>(){"t","u","v" } },
                { 9, new List<string>(){"w","x","y", "z" } }
                };

            List<List<string>> numsnew = new List<List<string>>();

            for (int i = 0; i < digits.Length; i++)
            {
                numsnew.Add(nums[(int)digits[i] - 48]);

            }
            for (int i = 0; i < numsnew.Count; i++)
            {
                List<string> rstemp = new List<string>();

                if (i == 0)
                {
                    for (int j = 0; j < numsnew[i].Count; j++)
                    {
                        rstemp.Add(numsnew[i][j]);
                    }

                }
                else
                {
                    for (int j = 0; j < numsnew[i].Count; j++)
                    {
                        IList<string> rstempin = new List<string>();

                        for (int k = 0; k < rs.Count; k++)
                        {
                            rstempin.Add(rs[k] + numsnew[i][j] );
                        }
                        //rs.Clear();
                        //for (int l = 0; l < rstempin.Count; l++)
                        //{
                        //    //if (rstemp[l].Length - 1 == i)
                        //    rstemp.Add(rstempin[l]);
                        //}
                        rstemp.AddRange(rstempin);
                    }
                }

                //rs.Clear();
                //for (int j = 0; j < rstemp.Count; j++)
                //{

                //    if (rstemp[j].Length - 1 == i)
                //        rs.Add(rstemp[j]);
                //}
                rs = rstemp;
            }
            return rs;
        }
    }
}
