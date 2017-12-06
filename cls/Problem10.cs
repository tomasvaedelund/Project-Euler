using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem10
    {
        public Problem10()
        {
            Console.WriteLine("Problem 10");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private long getAnswer()
        {
            var max = 2000000;
            var prime = 0;
            long result = 0;

            while ((prime = Helpers.GetNextPrime(prime)) < max)
            {
                result += prime;
            }

            return result;

        }
    }
}
