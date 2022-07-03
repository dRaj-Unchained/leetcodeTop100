using System;

namespace _35_SearchInsertPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp = { 1, 3, 5 };
            Console.WriteLine("Hello World!" + SearchInsert(inp, 4));
        }
        public static int SearchInsert(int[] nums, int target)
        {
            int l = 0, r = nums.Length - 1;
            if (target <= nums[l])
                return l;
            if (target > nums[r])
                return r+1;
            if (target == nums[r])
                return r ;
            r--;
            l++;
            while (l < r)
            {
                int m = (l + r + 1) / 2;
                if (nums[l] == target)
                    return l;
                if (nums[r] == target)
                    return r;
                if (nums[m] == target)
                    return m;
                if (target > nums[m])
                {
                    l = m + 1;
                    r--;
                }
                else
                {
                    r = m - 1;
                    l++;
                }
            }
            return l;
        }
    }
}
