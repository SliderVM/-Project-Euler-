using Common;
using System;
using System.Numerics;

namespace Factorial_digit_sum__20_
{
    class Program
    {
        static void Main(string[] args)
        {
            var common = new CommonClass();
            var fact = ProdTree(2, 100);
            var strNumber = fact.ToString();
            Console.WriteLine(common.GetDigitSum(strNumber));
            Console.ReadKey();
        }

        /// <summary>
        /// Алгоритм вычисления факториала деревом
        /// </summary>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        static BigInteger ProdTree(int l, int r)
        {
            if (l > r)
                return 1;
            if (l == r)
                return l;
            if (r - l == 1)
                return (BigInteger)l * r;
            int m = (l + r) / 2;
            return ProdTree(l, m) * ProdTree(m + 1, r);
        }
    }
}
