namespace P02.GenericBoxOfInteger
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesCount; i++)
            {
                int value = int.Parse(Console.ReadLine());

                Box<int> boxWithInt = new Box<int>(value);

                Console.WriteLine(boxWithInt);
            }
        }
    }
}