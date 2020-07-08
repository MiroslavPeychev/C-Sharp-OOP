namespace _4._Symbol_in_Matrix
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char[,] symbols = new char[n, n];

            for (int row = 0; row < symbols.GetLength(0); row++)
            {
                char[] symbol = Console.ReadLine()
                    .Trim()
                    .ToArray();

                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    symbols[row, col] = symbol[col];
                }
            }

            char findSymbol = char.Parse(Console.ReadLine());
            int currentRow = 0;
            int currentCol = 0;

            for (int row = 0; row < symbols.GetLength(0); row++)
            {
                for (int col = 0; col < symbols.GetLength(1); col++)
                {
                    if (symbols[row, col] == findSymbol)
                    {
                        currentRow = row;
                        currentCol = col;

                        Console.WriteLine($"({currentRow}, {currentCol})");
                        return;
                    }

                }
            }

            Console.WriteLine($"{findSymbol} does not occur in the matrix");
        }
    }
}