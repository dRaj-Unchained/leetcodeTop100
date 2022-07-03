using System;

namespace _34_FindFirstLastPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //            [5,7,7,8,8,10]
            //6
            //            [5,7,7,8,8,10]
            //8
            int[] inp = { 6, 8, 8, 8 ,8, 8, 8, 9 };

            int[] pri = SearchRange(inp, 6);

            Console.WriteLine("Hello World!");
        }

        //static public int[] SearchRange(int[] nums, int target)
        //{

        //    int l = nums.Length;
        //    int i = 0;
        //    int first = -1;
        //    int last = -1;

        //    while (i < l) {
        //        if (nums[i] == target)
        //        {
        //            if (first == -1)
        //            {
        //                first = i;
        //            }
        //            else {
        //                last = i;
        //            }
        //        }
        //        i++;
        //    }
        //    int[] ou = { first, last };
        //    return ou;
        //}

        static public int[] SearchRange(int[] nums, int target)
        {

            int right = nums.Length - 1;
            int left = 0;
            int first = int.MaxValue;
            int last = int.MinValue;

            while (left <= right)
            {
                if (nums[left] == target )
                {

                    first = Math.Min(first, left);
                    last = Math.Max(last, left);
                }
                if (  nums[right] == target)
                {

                    first = Math.Min(first, right);
                    last = Math.Max(last, right);
                }
                int mid = (left + right) / 2;
                //if (nums[mid] == target)
                //{
                //    if (first == -1)
                //    {
                //        first = last = mid;
                //    }
                //    else
                //    {
                //        last = Math.Max(last, mid);
                //    }
                //}
                //if (nums[right] == target)
                //{
                //    last = Math.Max(last, right);
                //}
                if (target > nums[right] || target < nums[left])
                    break;
                if (nums[left] == nums[right] && nums[right] == target)
                    break;
                if (nums[mid] > target)
                {
                    right = mid;
                    left++;
                }
                else if (nums[mid] < target)
                {
                    left = mid;
                    right--;
                }
                else
                {
                    left++;
                    right--;
                }
            }
            if (first == int.MaxValue)
                first = -1;
            if (last== int.MinValue)
                last= -1;
            int[] ou = { first, last };
            return ou;
        }
    }
}
