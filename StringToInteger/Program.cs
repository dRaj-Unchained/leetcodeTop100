using System;

namespace StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = MyAtoi(" - 123esd");
            Console.WriteLine("Hello World!  " + r);
        }

        public static int MyAtoi(string s)
        {
            bool neg = false;
            int res = 0;
            bool watingforsign = true;
            bool spacesfirst = true;

            //for (int i = 0; i < s.Length; i++)
            //{
            //    if (s[i] == ' ')
            //    {
            //        continue;
            //    }
            //    else if (s[i] == '-')
            //    {
            //        neg = true;
            //        break;
            //    }
            //    else {
            //        break;
            //    }
            //}

            for (int i = 0; i < s.Length; i++) {
                if (s[i] == ' ') {

                    if (spacesfirst)
                        continue;
                    else
                        break;
                }
                spacesfirst = false;

                if (Char.IsNumber(s[i]))
                {
                    watingforsign = false;
                    int rem =   (int)s[i]- 48;

                    if (!neg)
                    {
                        //if (res >= ((int.MaxValue / 10) + 48 - (int)s[i]))
                        if (res > Int32.MaxValue / 10 || (res == Int32.MaxValue / 10 && rem > 7))
                        {
                            res = int.MaxValue;
                            break;
                        }
                    }
                    if (neg)
                    {
                        if (res*-1 < Int32.MinValue / 10 || (res*-1 == Int32.MinValue / 10 && rem*-1 < -8))
                        {
                            res = int.MinValue;
                            break;
                        }
                    }
                    res = res * 10 + (int)s[i] - 48;
                }
                else if (watingforsign && (s[i] == '-' || s[i] == '+'))
                {
                    neg = s[i] == '-';
                    watingforsign = false;
                    continue;
                }
                else {
                    break;
                }
            }
           
            if (neg)
                res *= -1;
            return res;
        }
    }
}
