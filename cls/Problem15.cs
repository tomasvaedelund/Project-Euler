using System;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler.cls
{
    public class Problem15
    {
        public Problem15()
        {
            Console.WriteLine("Problem 15");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private BigInteger getAnswer()
        {
            var n = 20;
            var k = 20;

            // https://en.wikipedia.org/wiki/Pascal%27s_triangle#Rows
            n = 2 * n;

            // https://en.wikipedia.org/wiki/Pascal%27s_triangle#Combinations
            return getFactorial(n) / (getFactorial(k) * getFactorial(n - k));
        }

        private BigInteger getFactorial(int n)
        {
            var counter = 1;
            BigInteger result = 1;

            while (counter <= n)
            {
                result = checked(result * counter);
                counter++;
            }

            return result;
        }
    }
}