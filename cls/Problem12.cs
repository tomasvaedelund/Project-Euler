using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem12
    {
        public Problem12()
        {
            Console.WriteLine("Problem 12");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var maxNumberOfDivisors = 500;

            for (int i = 0; i < int.MaxValue; i++)
            {
                // https://en.wikipedia.org/wiki/Triangular_number
                var triangle = (i * (i + 1)) / 2;

                var numberOfDivisors = getNumberOfDivisors(triangle);

                if (numberOfDivisors > maxNumberOfDivisors)
                {
                    return triangle;
                }
            }

            return 0;
        }

        private int getNumberOfDivisors(int value)
        {
            var limit = (int)Math.Sqrt(value);

            var numberOfDivisors = 0;

            for (int i = 1; i <= limit; i++)
            {
                if (value % i == 0)
                {
                    numberOfDivisors++;

                    // http://stackoverflow.com/questions/239865/best-way-to-find-all-factors-of-a-given-number-in-c-sharp
                    if (i != value / i)
                    {
                        numberOfDivisors++;
                    }
                }
            }

            return numberOfDivisors;
        }
    }
}