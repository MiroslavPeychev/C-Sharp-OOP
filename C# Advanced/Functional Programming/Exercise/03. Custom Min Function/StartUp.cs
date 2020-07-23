namespace _03._Custom_Min_Function
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Func<int[], int> minNumber = n => n.Min();

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(minNumber(numbers));
        }
    }
}