using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem23
    {
        public Problem23()
        {
            Console.WriteLine("Problem 22");

            var sw = Stopwatch.StartNew();
            var answer = GetAnswer();
            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int GetAnswer()
        {
            var result = 0;

            return result;
        }
    }
}
