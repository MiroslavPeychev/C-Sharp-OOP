namespace _3._Primary_Diagonal
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            var matrix = new int[size, size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int sumDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                sumDiagonal += matrix[i, i];
            }

            Console.WriteLine(sumDiagonal);
        }
    }
}