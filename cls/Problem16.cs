using System;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler.cls
{
    public class Problem16
    {
        public Problem16()
        {
            Console.WriteLine("Problem 16");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private BigInteger getAnswer()
        {
            var number = 2;
            var expo = 1000;
            BigInteger check = checked((BigInteger)Math.Pow(number, expo));

            return getSumOfDigits(check);
        }

        private BigInteger getSumOfDigits(BigInteger v)
        {
            BigInteger result = 0;
            while (v > 0)
            {
                result += v % 10;
                v /= 10;
            }

            return result;
        }
    }
}
