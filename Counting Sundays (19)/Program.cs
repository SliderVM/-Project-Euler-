using System;

namespace Counting_Sundays__19_
{
    class Program
    {
        static void Main(string[] args)
        {               
            var stratDay = 6;
            var stopDay = 31;
            var SundaysCount = 0;
            var day = stratDay;

            for (var year = 1901; year <2001; year++)
            {
                for(var month = 1; month <=12; month++)
                {
                    if(month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        stopDay = 30;
                    }
                    else
                    {
                        stopDay = 31;
                    }

                    if(month == 2)
                    {
                        if(year % 1000 == 0 && year % 400 == 0)
                        {
                            stopDay = 29;
                        }else if(year % 4 == 0)
                        {
                            stopDay = 29;
                        }
                        else
                        {
                            stopDay = 28;
                        }
                    }

                    do
                    {
                        day += 7;

                        if(stratDay == 1)
                        {
                            SundaysCount++;
                        }
                        
                        stratDay = day - stopDay;

                    } while (day < stopDay);

                    day = stratDay;
                }
            }

            Console.WriteLine(SundaysCount);
            Console.ReadKey();
        }
    }
}
