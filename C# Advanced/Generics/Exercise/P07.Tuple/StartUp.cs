namespace P07.Tuple
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstInput = SplitInput();

            string firstName = firstInput[0];
            string lastName = firstInput[1];
            string address = firstInput[2];
            string fullName = $"{firstName} {lastName}";


            string[] secondInput = SplitInput();

            string name = secondInput[0];
            int litersBeerToDrink = int.Parse(secondInput[1]);

            string[] thirdInput = SplitInput();

            int firstArgument = int.Parse(thirdInput[0]);
            double secondArgument = double.Parse(thirdInput[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, litersBeerToDrink);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(firstArgument, secondArgument);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }

        public static string[] SplitInput()
        {
            string[] splittedInput = Console.ReadLine()
                .Split();

            return splittedInput;
        }
    }
}