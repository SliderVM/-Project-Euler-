using System;

namespace Number_letter_counts__17_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words0 = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] words1 = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] words2 = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            var res = 0;
            var j = 0;
            var jj = 0;

            for(var i=1; i <= 1000; i++)
            {   
                if (i < 10)
                {
                    res += words0[i].Length;
                }else if (i < 20)
                {
                    res += words1[(i%10)].Length;
                }else if (i < 100)
                {
                    j = i % 10;
                    if (j > 0)
                    {
                        res += (words2[i / 10] + words0[j]).Length;
                    }
                    else
                    {
                        res += (words2[i / 10]).Length;
                    }
                    
                }else if (i < 1000)
                {
                    j = i % 100;
                    if (j == 0)
                    {
                        res += (words0[i / 100] + "hundred").Length;
                    }
                    else if (j < 10)
                    {
                        res += (words0[i / 100] + "hundredand" + words0[j]).Length;
                    }else if(j<20)
                    {
                        res += (words0[i / 100] + "hundredand" + words1[(j % 10)]).Length;
                    }else if (j < 100)
                    {
                        jj = j % 10;                        
                        if (jj > 0)
                        {
                            res += (words0[i / 100] + "hundredand" + words2[j / 10] + words0[jj]).Length;
                        }
                        else
                        {
                            res += (words0[i / 100] + "hundredand" + words2[j / 10]).Length;
                        }
                        
                    }
                }
            }
            res += "onethousand".Length;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
