using Common;
using System;

namespace Summation_of_primes__10_
{
    class Program
    {
        static void Main(string[] args)
        {
            var com = new CommonClass();            
            ulong sum = 5;

            for(ulong i = 5; i<2000000; i = i + 2)
            {
                sum += com.CheckPrimeNumber(i) ? i : 0;
            }

            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
