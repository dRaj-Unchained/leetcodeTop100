using System;

namespace RemoveElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp = {1,4,3,2,3,2 };
            Console.WriteLine("Hello World!" + RemoveElement(inp,3));
        }
        public static int RemoveElement(int[] nums, int val)
        {
            int k = nums.Length;
            for (int j = 0; j < k; j++) {
                if (nums[j] == val)
                {
                    nums[j] = nums[k - 1];
                    k--;
                    j--;
                }
                 

            }
            return k;
        }
    }
}
