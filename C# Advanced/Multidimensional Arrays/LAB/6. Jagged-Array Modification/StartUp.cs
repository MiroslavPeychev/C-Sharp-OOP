namespace _6._Jagged_Array_Modification
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int sizeMatrix = int.Parse(Console.ReadLine());
            int[,] matrix = new int[sizeMatrix, sizeMatrix];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] elementsInCol = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = elementsInCol[j];
                }
            }

            string[] commandLine = Console.ReadLine()
                .Split();

            while (commandLine[0] != "END")
            {
                string command = commandLine[0];
                int firstCoordinat = int.Parse(commandLine[1]);
                int secondCoordinat = int.Parse(commandLine[2]);
                int operant = int.Parse(commandLine[3]);

                if (firstCoordinat > matrix.GetLength(0) - 1 || firstCoordinat < 0 || secondCoordinat > matrix.GetLength(1) - 1 || secondCoordinat < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {
                    if (command == "Add")
                    {
                        matrix[firstCoordinat, secondCoordinat] += operant;
                    }
                    else if (command == "Subtract")
                    {
                        matrix[firstCoordinat, secondCoordinat] -= operant;
                    }
                }

                commandLine = Console.ReadLine().Split();
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }

                Console.WriteLine();
            }
        }
    }
}