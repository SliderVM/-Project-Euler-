using Common;
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
            var common = new CommonClass();            

            Console.WriteLine(common.GetDigitSum(strNumber));
            Console.ReadKey();
        }
    }
}
