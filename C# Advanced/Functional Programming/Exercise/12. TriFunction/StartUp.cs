namespace _12._TriFunction
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string[] inputNames = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string> print = p => Console.WriteLine(p);

            Func<string, int, bool> isEqualSum = (name, totalSum) => name.Sum(x => x) >= totalSum;

            Func<string[], Func<string, int, bool>, string> firstNameFunc = (names, isEqualSumOfAscci) => names.FirstOrDefault(x => isEqualSum(x, number));

            var result = firstNameFunc(inputNames, isEqualSum);

            print(result);
        }
    }
}