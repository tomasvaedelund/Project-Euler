using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem9
    {
        public Problem9()
        {
            System.Console.WriteLine("Problem 9");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var max = 1000;

            for (int a = 0; a < max; a++)
            {
                for (int b = a + 1; b < max; b++)
                {
                    for (int c = b + 1; c < max; c++)
                    {
                        if (a * a + b * b == c * c && a + b + c == max)
                        {
                            return a * b * c;
                        }
                    }
                }
            }

            return 0;
        }
    }
}
