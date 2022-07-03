using System;
using System.Collections.Generic;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { -4, -2, 1, -5, -4, -4, 4, -2, 0, 4, 0, -2, 3, 1, -5, 0 };
            var a = ThreeSum(input);
            Console.WriteLine("Hello World!");
        }
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> tuples = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {

                for (int j = i + 1; j < nums.Length - 1; j++)
                {
                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        IList<int> tuple = new List<int>();

                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            int a, b, c, d;
                            a = nums[i];
                            b = nums[j];
                            c = nums[k];
                            if (a > b)
                            {
                                d = a;
                                a = b;
                                b = d;
                            }
                            if (b > c)
                            {
                                d = b;
                                b = c;
                                c = d;
                            }
                            if (a > b)
                            {
                                d = a;
                                a = b;
                                b = d;
                            }
                            tuple.Add(a);
                            tuple.Add(b);
                            tuple.Add(c);
                            //int index = tuples.IndexOf(item => testItem.Id == item.Id);


                            //if (index>-1)
                                tuples.Add(tuple);
                        }
                    }
                }
            }

            return tuples;
        }

    }
}
