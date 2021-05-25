using System;

namespace InstaGramSosa2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOf3Numbers(1, 2, 3));
        }

        public static int SumOf3Numbers(int a, int b, int c)
        {
            int result = a + b + c;

            return result;
        }
    }
}
