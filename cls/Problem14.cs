using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem14
    {
        public Problem14()
        {
            Console.WriteLine("Problem 14");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private string getAnswer()
        {
            var max = 0;
            var number = 1;

            for (int i = 0; i < 1000000; i++)
            {
                var count = countSequence(i);
                if (max < count)
                {
                    max = count;
                    number = i;
                }
            }

            return string.Format("{0} ({1})", max, number);
        }

        private int countSequence(int number)
        {
            var result = 1;
            long temp = number;

            while (temp > 1)
            {
                temp = (temp % 2 == 0) ? temp / 2 : 3 * temp + 1;
                result++;
            }

            return result;
        }
    }
}