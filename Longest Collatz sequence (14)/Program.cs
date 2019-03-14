using System;
using System.Collections.Generic;

namespace Longest_Collatz_sequence__14_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequenceCount = 0;
            ulong n = 0;

            for (ulong i = 500000; i<1000000; i++)
            {   
                var sc = IterativeSequence(i, new List<ulong>()).Count;
                if(sc > sequenceCount)
                {
                    n = i;
                    sequenceCount = sc;
                }
            }

            Console.WriteLine(n);
            Console.ReadKey();
        }

        public static List<ulong> IterativeSequence(ulong n, List<ulong> sequence)
        {
            sequence.Add(n);
            if(n > 1)
            {
                if (n % 2 == 0)
                {
                    IterativeSequence(n / 2, sequence);
                }
                else
                {
                    IterativeSequence(3 * n + 1, sequence);
                }
            }

            return sequence;
        }
    }
}
