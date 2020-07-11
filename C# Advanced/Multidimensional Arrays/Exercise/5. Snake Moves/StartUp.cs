namespace _5._Snake_Moves
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int[] dimentions = Console.ReadLine()
               .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            char[][] matrix = new char[rows][];

            char[] snakeStr = Console.ReadLine()
                .ToCharArray();

            Queue<char> snakeQueue = new Queue<char>(snakeStr);

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = new char[cols];

                for (int col = 0; col < cols; col++)
                {
                    char charToAdd = snakeQueue.Dequeue();
                    matrix[row][col] = charToAdd;
                    snakeQueue.Enqueue(charToAdd);
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, matrix.Select(r => String.Join("", r))));
        }
    }
}