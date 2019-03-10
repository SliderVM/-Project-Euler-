using System;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 res = 0;
            Int64 i = 40;
            
            do
            {
                if (IsRes(i))
                {
                    res = i;
                }
                else
                {
                    i++;
                }

            } while (res == 0);

            Console.WriteLine(res);
            Console.ReadKey();
        }

        static bool IsRes(Int64 num)
        {   
            for (var j = 20; j >= 2; j--)
            {
                if (num % j != 0)
                {
                    return false;
                }                
            }

            return true;
        }
    }
}
