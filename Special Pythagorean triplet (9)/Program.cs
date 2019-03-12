using System;

namespace Special_Pythagorean_triplet__9_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 1;
            var c = 1;

            for(var i = 1; i<500; i++)
            {
                for(var j = 1; j<500; j++)
                {
                    if(((1000 * i) + (1000 * j) - (i * j)) == 500000)
                    {
                        if( i > j)
                        {
                            b = i;
                            a = j;
                        }
                        else
                        {
                            b = j;
                            a = i;
                        }
                        break;
                    }
                }
                if (a > 1)
                {
                    break;
                }
            }

            c = 1000 - a - b;
            var prod = a * b * c;

            Console.WriteLine($"a = {a}, b = {b}, c = {c}, prod = {prod}");
            Console.ReadKey();
        }
    }
}
