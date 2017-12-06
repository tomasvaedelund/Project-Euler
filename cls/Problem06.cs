using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem6
    {
        public Problem6()
        {
            Console.WriteLine("Problem 6");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private object getAnswer()
        {
            var max = 100;
            var sumOfSquares = 0;
            var squareOfSums = 0;

            for (int i = 1; i <= max; i++)
            {
                sumOfSquares += (int)Math.Pow(i, 2);
                squareOfSums += i;
            }

            return Math.Abs(sumOfSquares - (int)Math.Pow(squareOfSums, 2));
        }
    }
}