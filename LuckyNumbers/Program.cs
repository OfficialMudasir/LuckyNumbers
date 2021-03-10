using System;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9, y = 1;
            Lucky_8(x, y);

        }
        public static bool Lucky_8(int a,int b)
        {
            bool result = false;
            
            int sum = a + b;
            int sub = a - b;
            if (sum == 8 || sub == 8 || a == 8 || b == 8)
            {
                result = true;
                Console.WriteLine("Input: a = " + a + ", b = " + b);
                Console.WriteLine("Output: " + result);
                return result;

            }
            else
            {
                Console.WriteLine("Input: a = " + a + ", b = " + b);
                Console.WriteLine("Output: " + result);
                return result;
            }
        }
    }
}
