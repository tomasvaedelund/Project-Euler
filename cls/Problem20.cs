using System;
using System.Diagnostics;
using System.Numerics;

namespace ProjectEuler.cls
{
    public class Problem20
    {
        public Problem20()
        {
            Console.WriteLine("Problem 20");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var start = 100;
            var factorial = Helpers.GetFactorial(start);
            var result = 0;

            while (factorial > 1)
            {
                result += (int)(factorial % 10);
                factorial /= 10;
            }

            return result;
        }
    }
}
