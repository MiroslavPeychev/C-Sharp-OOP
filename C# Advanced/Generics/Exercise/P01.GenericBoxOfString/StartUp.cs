namespace P01.GenericBoxOfString
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                string value = Console.ReadLine();

                Box<string> boxWithString = new Box<string>(value);

                Console.WriteLine(boxWithString);
            }
        }
    }
}