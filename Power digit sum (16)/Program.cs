using System;
using System.Collections;
using System.Numerics;
using System.Text;

namespace Power_digit_sum__16_
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = new BigInteger();
            number = 2;
            for(var i=0; i<999; i++)
            {
                number *= 2;
            }

            var strNumber = number.ToString();
            int res = 0;
            foreach(var i in strNumber)
            {
                res += (int)char.GetNumericValue(i);
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
