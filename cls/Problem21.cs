using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem21
    {
        public Problem21()
        {
            Console.WriteLine("Problem 21");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private object getAnswer()
        {
            var result = 0;
            for (int i = 1; i < 10000; i++)
            {
                var candidate = Helpers.GetSumOfDivisors(i);
                if (candidate > i && Helpers.GetSumOfDivisors(candidate) == i)
                {
                    result += i + candidate;
                }
            }

            return result;
        }
    }
}
