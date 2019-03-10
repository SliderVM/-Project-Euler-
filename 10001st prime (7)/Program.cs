using Common;
using System;


namespace _10001st_prime__7_
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = 6;
            Int64 number = 13;
            var com = new CommonClass();
            do
            {
                number++;
                if (com.CheckPrimeNumber(number))
                {
                    counter++;
                }
                
            } while (counter != 10001);

            Console.WriteLine(number);
            Console.ReadKey();
        }
    }
}
