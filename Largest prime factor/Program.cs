using System;
using System.Collections.Generic;

namespace Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = (Int64)Math.Sqrt(600851475143);
            var delit = new List<Int64>();
            for (var i = start + 1 ; i>2; i--)
            {
                if(600851475143 % i == 0)
                {
                    delit.Add(i);                    
                }                
            }            
            
            foreach(var i in delit)
            {
                if (CheckPrimeNumber(i))
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.ReadKey();
        }

        static bool CheckPrimeNumber(Int64 number)
        {
            var start = (Int64)Math.Sqrt(number);
            for (var i = start + 1; i > 1; i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
