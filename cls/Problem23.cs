using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem23
    {
        private readonly int limit = 28123;

        public Problem23()
        {
            Console.WriteLine("Problem 23");

            var sw = Stopwatch.StartNew();
            var answer = GetAnswer();
            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int GetAnswer()
        {
            var result = 0;

            var abundantNumbers = GetAbundantNumbers();
            var abundantSums = GetAbundantSums(abundantNumbers);

            for (int i = 0; i <= limit; i++)
            {
                result += (abundantSums[i]) ? 0 : i;
            }

            return result;
        }

        private List<int> GetAbundantNumbers()
        {
            var abundantNumbers = new List<int>();

            for (int i = 2; i <= limit; i++)
            {
                var sum = Helpers.GetSumOfDivisors(i);

                if (sum > i)
                {
                    abundantNumbers.Add(i);
                }
            }

            return abundantNumbers;
        }

        private bool[] GetAbundantSums(List<int> abundantNumbers)
        {
            var abundantSums = new bool[limit + 1];

            for (int i = 0; i < abundantNumbers.Count; i++)
            {
                for (int j = 0; j < abundantNumbers.Count; j++)
                {
                    var checker = abundantNumbers[i] + abundantNumbers[j];
                    if (checker <= limit)
                    {
                        abundantSums[checker] = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return abundantSums;
        }
    }
}
