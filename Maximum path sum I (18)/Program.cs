using System;
using System.Linq;

namespace Maximum_path_sum_I__18_
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = @"75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";

            var numLines = str.Replace("\r", "").Split('\n');
            var line = 0;            
            
            int[][] triangle = new int[numLines.Length][];

            foreach(var s in numLines)
            {
                var lineArr = s.Split(' ');
                var lineArrInt = new int[lineArr.Length];
                for (var i =0; i < lineArr.Length; i++)
                {
                    lineArrInt[i] = int.Parse(lineArr[i]);
                }
                triangle[line] = lineArrInt;
                line++;
            }

            int sum, sum1, sum2 = 0;
            for(var i = 1; i< triangle.Length; i++)
            {
                for(var j = 0; j < triangle[i].Length; j++)
                {
                    sum = sum1 = sum2 = 0;

                    if ((j-1) >= 0)
                    {
                        sum = triangle[i][j] + triangle[i - 1][j - 1];
                    }

                    if(j < triangle[i - 1].Length)
                    {
                        sum1 = triangle[i][j] + triangle[i - 1][j];
                    }                    

                    if((j+1) < triangle[i - 1].Length)
                    {
                        sum2 = triangle[i][j] + triangle[i - 1][j+1];
                    }

                    triangle[i][j] = sum1;

                    if(triangle[i][j] < sum)
                    {
                        triangle[i][j] = sum;
                    }
                    /*
                    if (triangle[i][j] < sum2)
                    {
                        triangle[i][j] = sum2;
                    }
                    */
                }
            }

            Console.WriteLine(triangle[triangle.Length - 1].Max());
            Console.ReadKey();
        }
    }
}
