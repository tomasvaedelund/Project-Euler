using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem7
    {
        public Problem7()
        {
            Console.WriteLine("Problem 7");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private object getAnswer()
        {
            var max = 10001;
            var primes = new int[max];

            primes[0] = 2;
            for (int i = 1; i < max; i++)
            {
                primes[i] = Helpers.GetNextPrime(primes[i - 1]);
            }

            return primes[max - 1];
        }
    }
}
