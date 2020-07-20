namespace _01._Count_Same_Values_in_Array
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            double[] nums = Console.ReadLine()
               .Split(' ')
               .Select(double.Parse)
               .ToArray();

            Dictionary<double, int> counts = new Dictionary<double, int>();

            foreach (double num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (KeyValuePair<double, int> num in counts)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}