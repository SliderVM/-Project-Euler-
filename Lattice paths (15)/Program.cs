using System;

namespace Lattice_paths__15_
{
    class Program
    {
        static void Main(string[] args)
        {  
            int n = 21;
            int m = 21;
            ulong[,] w = new ulong[m, n];

            for(var i = 0; i < n; i++)
            {
                w[0,i] = 1;                
            }

            for(var i = 1; i < n; i++)
            {
                w[i, 0] = 1;
                for(var j= 1; j < m; j++)
                {
                    w[i, j] = w[i - 1, j] + w[i, j - 1];
                }
            }

            Console.WriteLine(w[n-1,m-1]);
            Console.ReadKey();
        }
    }
}
