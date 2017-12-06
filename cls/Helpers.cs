using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ProjectEuler.cls
{
    public static class Helpers
    {
        public static int GetNextPrime(int start)
        {
            for (int i = start + 1; i < int.MaxValue; i++)
            {
                if (i.IsPrime())
                {
                    return i;
                }
            }

            throw new Exception("Didn't find a next prime");
        }

        public static bool IsPrime(this int candidate)
        {
            if (candidate <= 1)
            {
                return false;
            }

            if (candidate == 3)
            {
                return true;
            }

            if (candidate % 2 == 0 || candidate % 3 == 0)
            {
                return false;
            }

            var i = 5;
            while (i * i <= candidate)
            {
                if (candidate % i == 0 || candidate % (i + 2) == 0)
                {
                    return false;
                }

                i += 6;
            }

            return true;
        }

        public static BigInteger GetFactorial(int n)
        {
            var counter = 1;
            BigInteger result = 1;

            while (counter <= n)
            {
                result = checked(result * counter);
                counter++;
            }

            return result;
        }

        public static List<int> GetDivisors(int value)
        {
            var divisors = new List<int>();

            var i = 1;
            while (i <= Math.Sqrt(value))
            {
                if (value % i == 0)
                {
                    divisors.Add(i);
                    if (i != value / i)
                    {
                        divisors.Add(value / i);
                    }
                }

                i++;
            }

            divisors.Remove(value);

            return divisors.OrderBy(x => x).ToList();
        }

        public static int GetSumOfDivisors(int value)
        {
            var result = 0;
            var divisors = GetDivisors(value);

            foreach (var divisor in divisors)
            {
                result += divisor;
            }

            return result;
        }
    }
}
