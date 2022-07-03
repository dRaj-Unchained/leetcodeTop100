using System;

namespace ReverseInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Reverse(-123456);
            Console.WriteLine("Hello World!  " + r);
        }

        public static int Reverse(int x)
        {
            int res = 0;
            while (x != 0) {
                res = (res * 10) + (x % 10);
                x /= 10;
            }
            return res;
        }
    }
}
