using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ProjectEuler.cls
{
    public class Problem22
    {
        public Problem22()
        {
            Console.WriteLine("Problem 22");

            Debug.Assert(GetNameValue("COLIN") == 53);

            var data = File.ReadAllLines("./data/problem22.txt");

            var sw = Stopwatch.StartNew();
            var answer = GetAnswer(data[0]);
            sw.Stop();

            Console.WriteLine("Answer: {0}, in {1}ms", answer, sw.ElapsedMilliseconds);
        }

        private long GetAnswer(string rawData)
        {
            var data = rawData
                .Replace("\"", "")
                .Split(',');

            data = BubleSort(data);

            Debug.Assert(data[937] == "COLIN");

            var result = 0L;

            for (int i = 0; i < data.Length; i++)
            {
                var nameValue = GetNameValue(data[i]);
                var nameScore = nameValue * (i + 1);

                result += nameScore;
            }

            return result;
        }

        private string[] BubleSort(string[] strings)
        {
            bool changed = true;

            while (changed)
            {
                changed = false;
                for (int i = 1; i < strings.Length; i++)
                {
                    if (!CompareStrings(strings[i - 1], strings[i]))
                    {
                        string temp = strings[i - 1];
                        strings[i - 1] = strings[i];
                        strings[i] = temp;
                        changed = true;
                    }
                }
            }
            return strings;
        }

        private bool CompareStrings(string str1, string str2)
        {
            int i = 0;
            while (i < str1.Length && i < str2.Length)
            {
                if (str1[i] == str2[i])
                {
                    i++;
                }
                else
                {
                    return str1[i] < str2[i];
                }
            }
            return str1.Length <= str2.Length;
        }

        private int GetNameValue(string name)
        {
            var result = 0;

            foreach (var c in name.ToCharArray())
            {
                result += (int)c - 64;
            }

            return result;
        }
    }
}
