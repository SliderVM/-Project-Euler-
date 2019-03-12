using System;

namespace Common
{
    public class CommonClass
    {
        public bool CheckPrimeNumber(Int64 number)
        {
            var start = (Int64)Math.Sqrt(number);
            for (var i = start + 1; i > 1; i--)
            {
                if (number % i == 0 && number != i)
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckPrimeNumber(ulong number)
        {
            var start = (ulong)Math.Sqrt(number);
            for (var i = start + 1; i > 1; i--)
            {
                if (number % i == 0 && number != i)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
