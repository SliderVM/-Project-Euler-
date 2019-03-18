using System;
using System.IO;
using System.Linq;

namespace Maximum_path_sum_I__18_
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = File.ReadAllText(@"p067_triangle.txt");

            var numLines = str.Replace("\r", "").Split('\n');
            var line = 0;

            int[][] triangle = new int[numLines.Length][];

            foreach (var s in numLines)
            {
                var lineArr = s.Split(' ');
                var lineArrInt = new int[lineArr.Length];
                for (var i = 0; i < lineArr.Length; i++)
                {
                    lineArrInt[i] = int.Parse(lineArr[i]);
                }
                triangle[line] = lineArrInt;
                line++;
            }

            int sum, sum1, sum2 = 0;
            for (var i = 1; i < triangle.Length; i++)
            {
                for (var j = 0; j < triangle[i].Length; j++)
                {
                    sum = sum1 = sum2 = 0;

                    if ((j - 1) >= 0)
                    {
                        sum = triangle[i][j] + triangle[i - 1][j - 1];
                    }

                    if (j < triangle[i - 1].Length)
                    {
                        sum1 = triangle[i][j] + triangle[i - 1][j];
                    }

                    if ((j + 1) < triangle[i - 1].Length)
                    {
                        sum2 = triangle[i][j] + triangle[i - 1][j + 1];
                    }

                    triangle[i][j] = sum1;

                    if (triangle[i][j] < sum)
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
