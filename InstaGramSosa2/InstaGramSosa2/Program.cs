using System;
using InstaGramSosa2.Models;

namespace InstaGramSosa2
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;

            for(var i=1; i<=20;i++)
            {
                result = result + i;
            }
            Console.WriteLine(result);
        }
    }
}
