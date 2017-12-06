using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem5
    {
        public Problem5()
        {
            Console.WriteLine("Problem 5");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var max = 20;

            for (int i = max; i < int.MaxValue; i += max)
            {
                if (isEvenlyDivisible(i, max))
                {
                    return i;
                }
            }

            return 0;
        }

        private bool isEvenlyDivisible(int number, int max)
        {
            if (number % max != 0)
            {
                return false;
            }

            for (int j = 1; j <= max; j++)
            {
                if ((number % j) != 0)
                {
                    return false;;
                }
            }

            return true;
        }
    }
}