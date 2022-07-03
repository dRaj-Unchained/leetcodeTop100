using System;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!" + IsValid("{[]}"));
        }
        public static bool IsValid(string s)
        {
            if (s.Length == 0 || s.Length == 1 || s.Length % 2 == 1)
                return false;
            int copen = 0;
            int dopen = 0;
            int eopen = 0;
            string canclose = s[0].ToString();
            for (int i = 0; i < s.Length; i++) {
                switch (s[i])
                {
                    case '(':
                        copen++;
                        canclose += ')';
                        break;
                    case ')':
                        if (s[i]!= canclose[canclose.Length-1])
                            return false;
                        copen--;
                        canclose = canclose.Substring(0, canclose.Length - 1);
                        break;
                    case '[':
                        dopen++;
                        canclose += ']';
                        break;
                    case ']':
                        if (s[i] != canclose[canclose.Length - 1])
                            return false;
                        canclose = canclose.Substring(0, canclose.Length - 1);
                        dopen--;
                        break;
                    case '{':
                        eopen++;
                        canclose += '}';
                        break;
                    case '}':
                        if (s[i] != canclose[canclose.Length - 1])
                            return false;
                        eopen--;
                        canclose = canclose.Substring(0, canclose.Length - 1);
                        break;
                    default:
                        break;
                }
                if (copen < 0 || dopen < 0 || eopen < 0)
                    return false;
            }
            if (copen == 0 && dopen == 0 && eopen == 0)
                return true;
            return false;
        }
    }
}
