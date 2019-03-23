using System;

namespace Common
{
    public class CommonClass
    {
        /// <summary>
        /// Проверка на простое число
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Проверка на простое число
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Получить сумму цифр числа
        /// </summary>
        /// <param name="digits"></param>
        /// <returns></returns>
        public int GetDigitSum(string digits)
        {
            int res = 0;
            foreach (var i in digits)
            {
                res += (int)char.GetNumericValue(i);
            }

            return res;
        }
    }
}
