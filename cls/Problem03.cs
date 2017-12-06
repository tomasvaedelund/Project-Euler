using System;
using System.Diagnostics;

namespace ProjectEuler.cls
{
    public class Problem3
    {
        public Problem3()
        {
            Console.WriteLine("Problem 3");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private long getAnswer()
        {
            var result = 600851475143;
            var prime = 0;
            var max = 0;
            
            while (result > 1)
            {
                prime = Helpers.GetNextPrime(prime);

                if (result % prime == 0)
                {
                    result /= prime;
                    max = (max > prime) ? max : prime;
                    prime = 0;
                }
            }

            return max;
        }
    }
}
