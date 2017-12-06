using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem2
    {
        private const int max = 4000000;
        
        public Problem2()
        {
            Console.WriteLine("Problem 2");
            
            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var result = 0;
            var previous = 0;
            var current = 1;
            var temp = 0;

            while (current < max)
            {
                result += (current % 2 == 0) ? current : 0;
                temp = previous;
                previous = current;
                current = previous + temp;
            }

            return result;
        }
    }
}