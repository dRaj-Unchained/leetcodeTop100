using System;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool r = IsPalindrome(222);
            Console.WriteLine("Hello World!" + r);
        }
        public static bool IsPalindrome(int x)
        {

            if (x < 0 || (x % 10 == 0 && x != 0))
            {
                return false;
            }
            int rev = 0;
            while (x > rev)
            {
                rev = rev * 10 + x % 10;
                x /= 10;
            }
            return rev == x || x == rev / 10; ;
        }
    }
}
