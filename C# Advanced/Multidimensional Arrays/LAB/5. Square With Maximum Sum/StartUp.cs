namespace _5._Square_With_Maximum_Sum
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] dimentions = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var currentRow = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col]
                        + matrix[row, col + 1]
                        + matrix[row + 1, col]
                        + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRowIndex = row;
                        maxColIndex = col;
                    }
                }
            }

            Console.WriteLine($"{matrix[maxRowIndex, maxColIndex]} {matrix[maxRowIndex, maxColIndex + 1]}");
            Console.WriteLine($"{matrix[maxRowIndex + 1, maxColIndex]} {matrix[maxRowIndex + 1, maxColIndex + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}