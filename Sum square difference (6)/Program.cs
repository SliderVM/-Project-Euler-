using System;

namespace Sum_square_difference__6_
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 s1 = 0;
            Int64 s2 = 0;
            for(var i = 1; i<=100; i++)
            {
                s1 += i * i;
                s2 += i;
            }

            Console.WriteLine(s2 * s2 - s1);
            Console.ReadKey();
        }
    }
}
