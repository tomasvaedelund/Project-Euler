using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem19
    {
        public Problem19()
        {
            Console.WriteLine("Problem 19");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            // January 1st 1901 = Tuesday
            var numDaysSinceSunday = 2;
            var result = 0;

            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    numDaysSinceSunday += getNumDays(year, month);
                    if (numDaysSinceSunday % 7 == 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        private int getNumDays(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    return (isLeapYear(year)) ? 29 : 28;
                default:
                    return 30;
            }
        }

        private bool isLeapYear(int year)
        {
            if ((year % 100 == 0 && year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                return true;
            }

            return false;
        }
    }
}
