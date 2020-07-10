namespace _1._Diagonal_Difference
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            long[,] matrix = new long[sizeMatrix, sizeMatrix];
            long primaryDiagonal = 0;
            long secondaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                long[] numbersInCol = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = numbersInCol[j];

                    if (j == i)
                    {
                        primaryDiagonal += matrix[i, j];
                    }
                    if (j == (sizeMatrix - 1 - i))
                    {
                        secondaryDiagonal += matrix[i, j];
                    }
                }
            }

            long difference = Math.Abs(primaryDiagonal - secondaryDiagonal);

            Console.WriteLine(difference);
        }
    }
}