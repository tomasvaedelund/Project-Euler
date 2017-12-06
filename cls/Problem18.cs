using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ProjectEuler.cls
{
    public class Problem18
    {
        public Problem18()
        {
            Console.WriteLine("Problem 18");

            Stopwatch sw = Stopwatch.StartNew();

            var answer = getAnswer();

            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private int getAnswer()
        {
            var result = new int[data.Length][];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = new int[data[i].Length];
            }

            // Skip first row, it never changes
            // Then calculate second row manually
            result[1][0] = data[1][0] + data[0][0];
            result[1][1] = data[1][1] + data[0][0];

            // Loop from third row
            for (int i = 2; i < data.Length; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    result[i][j] = data[i][j] + getPreviousMaxValue(i, j, result);
                }
            }

            return result[result.Length - 1].Max();
        }

        private int getPreviousMaxValue(int i, int j, int[][] result)
        {
            if (j == 0)
            {
                return result[i - 1][j];
            }

            if (j == result[i].Length - 1)
            {
                return result[i - 1][j - 1];
            }

            return (result[i - 1][j - 1] > result[i - 1][j]) ? result[i - 1][j - 1] : result[i - 1][j];
        }

        private int[][] data = new int[][]
        {
            new int[] { 75 },
            new int[] { 95, 64 },
            new int[] { 17, 47, 82 },
            new int[] { 18, 35, 87, 10 },
            new int[] { 20, 04, 82, 47, 65 },
            new int[] { 19, 01, 23, 75, 03, 34 },
            new int[] { 88, 02, 77, 73, 07, 63, 67 },
            new int[] { 99, 65, 04, 28, 06, 16, 70, 92 },
            new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 },
            new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 },
            new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 },
            new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 },
            new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 },
            new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 },
            new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
        };
    }
}
