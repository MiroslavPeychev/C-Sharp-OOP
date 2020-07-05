namespace _1._Reverse_Strings
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Stack<char> stack = new Stack<char>();
            string input = Console.ReadLine();

            foreach (char symbol in input)
            {
                stack.Push(symbol);
            }

            while (stack.Count != 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}