using System;

namespace IntegertoRoman
{
    class Program
    {
        static void Main(string[] args)
        {

            string rom = IntToRoman(40);
            Console.WriteLine("Hello World! " + rom);
        }
        public static string IntToRoman(int num)
        {
            string roman = "";

            int[] value = { 1000, 500, 100, 50, 10, 5, 1 };
            string[] symbol = { "M", "D", "C", "L", "X", "V", "I" };
            int pointer = 0;
            while (num > 0)
            {

                if (num >= value[pointer])
                {

                    
                    if (pointer != 0 && num >= value[pointer - 1] - value[pointer + pointer%2])
                    {
                        roman += symbol[pointer + pointer % 2] + symbol[pointer - 1];
                        num -= value[pointer - 1] - value[pointer + pointer % 2];

                    }   
                    else
                    {
                        roman += symbol[pointer];
                        num -= value[pointer];
                    }
                }
                else
                {
                    pointer++;
                }
            }

            return roman;
        }
    }
}
