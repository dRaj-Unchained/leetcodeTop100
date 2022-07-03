using System;


namespace _26_RemoveDuplicatesfromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp = { 0,0,1,1,1,2,2,3,3,4};
            Console.WriteLine("Hello World!" + RemoveDuplicates(inp));
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int k = nums.Length;
            int p = 0;
            for (int i = 1; i < k; i++)
            {
                if (nums[p] != nums[i])
                {
                    p++;

                    nums[p] = nums[i];
                    i--;
                }
                

            }
            return p;
        }
    }
}
