using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem1
    {
        private const int max = 1000;
        
        public Problem1()
        {
            Console.WriteLine("Problem 1");
            
            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var result = 0;

            for (int i = 1; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }

            return result;
        }
    }
}