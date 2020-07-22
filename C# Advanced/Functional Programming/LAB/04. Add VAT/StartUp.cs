namespace _04._Add_VAT
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            double[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                double current = input[i];
                double withVAT = current * 1.20;

                Console.WriteLine($"{withVAT:f2}");
            }
        }
    }   
}