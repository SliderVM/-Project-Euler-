using System;

namespace Even_Fibonacci_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 sum = 0;
            int[] num = new int[2];
            num[0] = 0;
            num[1] = 1;
            var i = 0;
            do
            {
                i = num[1];
                num[1] = num[0] + num[1];
                num[0] = i;
                if(num[1] % 2 == 0)
                {
                    sum += num[1];
                }
            } while (num[1] <= 4000000);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
