using Common;
using System;
using System.Collections.Generic;

namespace Highly_divisible_triangular_number__12_
{
    class Program
    {
        static void Main(string[] args)
        {
            var com = new CommonClass();
            ulong res = 0;
            ulong i = 8;
            ulong triangle = 28;
            var counter = 0;

            while (res == 0)
            {
                triangle += i;
                counter = 1;
                var dic = new Dictionary<ulong, int>();
                Decomposition(triangle, dic, com);

                if(dic.Count > 0)
                {
                    foreach(var item in dic)
                    {
                        counter *= item.Value + 1;                        
                    }
                }
                
                if(counter >= 498)
                {
                    res = triangle;
                    break;
                }

                i++;                
            }

            Console.WriteLine(res);
            Console.ReadKey();
        }

        static void Decomposition(ulong num, Dictionary<ulong, int> dic, CommonClass com)
        {
            if (com.CheckPrimeNumber(num))
            {
                if (dic.GetValueOrDefault(num) == 0)
                {
                    dic.Add(num, 1);
                }
                else
                {
                    dic[num]++;
                }
                return;
            }
            for (ulong j = 2; j <= num / 2; j++)
            {
                if (com.CheckPrimeNumber(j))
                {
                    if (num % j == 0)
                    {
                        if(dic.GetValueOrDefault(j) == 0)
                        {
                            dic.Add(j, 1);
                        }
                        else
                        {
                            dic[j]++;
                        }

                        Decomposition(num / j, dic, com);
                        break;
                    }
                }
            }
        }
    }
}
