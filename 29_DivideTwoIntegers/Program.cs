using System;

namespace _29_DivideTwoIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!" + Divide(-2147483648,2));
        }

        public static int Divide(int dividend, int divisor)
        {
            int multi = 1;
            int r = 0;

            if (dividend < 0 && divisor < 0)
            {

                while (dividend <= divisor)
                {
                    if (r == 2147483647)
                        break;
                    r++;
                    dividend -= divisor;
                }
            }
            else if (divisor < 0)
            {
                while (dividend*-1 <= divisor )
                {
                    r++;
                    dividend += divisor;
                    multi = -1;
                }
            }
            else if (dividend < 0)
            {
                while (dividend <= divisor * -1)
                {
                    r++;
                    dividend += divisor;
                    multi = -1;
                }
            }
            else
            {
                while (dividend >= divisor)
                {
                    r++;
                    dividend -= divisor;
                }
            }


            return r * multi;
        }
    }
}
