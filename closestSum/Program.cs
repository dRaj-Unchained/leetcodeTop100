using System;

namespace closestSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inp = { -1,2,1,-4 };
            int trs = ThreeSumClosest(inp, 1);
            Console.WriteLine("Hello World! " + trs);


        }

        public static int ThreeSumClosest(int[] nums, int target)
        {
            int rt= nums[0] + nums[1] + nums[2]  ;
            for(int i=0; i< nums.Length-2; i++)
            {

                for (int j = i+1; j < nums.Length; j++)
                {

                    for (int k = j + 1; k < nums.Length; k++)
                    {
                        int sum = nums[i] + nums[j] + nums[k];

                        int dist = sum - target;
                        int distout = rt - target;

                        if (dist < 0)
                            dist *= -1;

                        if (distout < 0)
                            distout *= -1;

                        if (distout > dist) {
                            rt = sum;
                        }
                    }
                }
            }
            return rt;
        }
    }
}
