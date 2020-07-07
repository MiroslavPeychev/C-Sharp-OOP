namespace _03._Maximum_and_Minimum_Element
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfinputLines = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numberOfinputLines; i++)
            {
                string currentInput = Console.ReadLine();

                switch (currentInput)
                {
                    case "2":
                        if (numbers.Any())
                        {
                            numbers.Pop();
                        }
                        break;
                    case "3":
                        if (numbers.Any())
                        {
                            sb.AppendLine(numbers.Max().ToString());
                        }
                        break;
                    case "4":
                        if (numbers.Any())
                        {
                            sb.AppendLine(numbers.Min().ToString());
                        }
                        break;

                    default:
                        string[] lineData = currentInput.Split();
                        int currentNum = int.Parse(lineData[1]);
                        numbers.Push(currentNum);
                        break;
                }
            }

            sb.AppendLine(string.Join(", ", numbers));
            Console.Write(sb);
        }
    }
}