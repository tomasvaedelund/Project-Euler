using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem17
    {
        public Problem17()
        {
            Console.WriteLine("Problem 17");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var result = "";

            for (int i = 1; i <= 1000; i++)
            {
                result += getWordsFromNumber(i);
            }

            var test1 = getWordsFromNumber(40).Replace(" ", "").Replace("-", "").Length;
            var test2 = getWordsFromNumber(115).Replace(" ", "").Replace("-", "").Length;

            return result.Replace(" ", "").Replace("-", "").Replace("\r\n", "").Length;
        }

        private string getWordsFromNumber(int number)
        {
            var result = "";
            var tensAdded = false;

            if (number / 1000 > 0)
            {
                result += getWordsFromNumber(number / 1000) + " thousand";
                number = number % 1000;
            }

            if (number / 100 > 0)
            {
                result += getWordsFromNumber(number / 100) + " hundred";
                number = number % 100;
            }

            if (number > 19 && number / 10 > 0)
            {
                var tens = new string[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                result += (result.Length == 0) ? "" : " and ";
                result += tens[number / 10 - 2];
                number = number % 10;
                tensAdded = true;
            }

            if (number <= 19 && number > 0)
            {
                var ones = new string[] { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                if (tensAdded)
                {
                    result += "-";
                }
                else
                {
                    result += (result.Length == 0) ? " " : " and ";
                }
                result += ones[number - 1];
            }

            return result.Replace("\r\n", "") + "\r\n";
        }
    }
}