namespace P08.Threeuple
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string[] firstInput = SplitInput();

            string firstName = firstInput[0];
            string lastName = firstInput[1];
            string address = firstInput[2];
            string fullName = $"{firstName} {lastName}";
            string town = string.Empty;

            if (firstInput.Length >= 5)
            {
                town = firstInput[3] + " " + firstInput[4];
            }
            else
            {
                town = firstInput[3];
            }

            string[] secondInput = SplitInput();

            string name = secondInput[0];
            int litersBeerToDrink = int.Parse(secondInput[1]);
            bool isDrunk = secondInput[2] == "drunk" ? true : false;

            string[] thirdInput = SplitInput();

            string thirdInputName = thirdInput[0];
            double accountBalance = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];

            Tuple<string, string, string> firstTuple = new Tuple<string, string, string>(fullName, address, town);
            Tuple<string, int, bool> secondTuple = new Tuple<string, int, bool>(name, litersBeerToDrink, isDrunk);
            Tuple<string, double, string> thirdTuple = new Tuple<string, double, string>(thirdInputName, accountBalance, bankName);

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