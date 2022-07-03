using System;

namespace _31_NextPermutation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp = { 1, 2, 3 };
            NextPermutation(inp);
            Console.WriteLine("Hello World!");
        }
        public static void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            for (; i >= 0; i--)
            {
                if (nums[i + 1] > nums[i])
                    break;
            }

            if (i >= 0)
            {
                int j = nums.Length - 1;
                for (; j > 0; j--)
                {
                    if (nums[j] > nums[i])
                    {
                        int tp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = tp;
                        break;
                    }
                }
            }
            int l = nums.Length - 1;
            for (int k = i+1; k <  l; k++)
            {
                int tp = nums[k];
                nums[k] = nums[l];
                nums[l] = tp;
                l--;
            }


        }
    }
}
