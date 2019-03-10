using System;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = 0;
            var polindron = 0;

            for(var i = 999; i>100; i--)
            {
                for(var j = 999; j>100; j--)
                {
                    p = i * j;                    

                    if(polindron > p)
                    {
                        continue;
                    }
                    var arr = p.ToString().ToCharArray();
                    if (arr.Length == 6)
                    {
                        if(arr[0] == arr[5] && arr[1] == arr[4] && arr[2] == arr[3])
                        {
                            polindron = p;
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            

            Console.WriteLine(polindron);
            Console.ReadKey();
        }
    }
}
