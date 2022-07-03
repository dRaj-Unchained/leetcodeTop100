using System;

namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp =  { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int r = MaxArea(inp);
                Console.WriteLine("Hello World!" + r);
        }
        public static int MaxArea(int[] height)
        {
            int maxwater = 0;
            int L = height.Length;
            int left = 0;
            int right = L - 1;
            while (left < right)
            {


                maxwater = Math.Max((right - left) * Math.Min(height[right], height[left]), maxwater);

                if (height[left] <= height[right])
                    left++;
                else
                    right--;
            }
            return maxwater;
        }
    }
}
