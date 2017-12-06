using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem4
    {
        public Problem4()
        {
            Console.WriteLine("Problem 4");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var result = 0;

            for (int i = 0; i <= 999; i++)
            {
                for (int j = 0; j <= 999; j++)
                {
                    var candidate = i * j;
                    if (isPalindromicNumber(candidate))
                    {
                        result = (candidate > result) ? candidate : result;
                    }
                }
            }

            return result;
        }

        private bool isPalindromicNumber(int candidate)
        {
            var number = candidate;
            var digit = 0;
            var reverse = 0;
            while (number > 0)
            {
                digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            if (candidate == reverse)
            {
                return true;
            }
           
            return false;
        }
    }
}