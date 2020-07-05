namespace _3._Simple_Calculator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();

            Stack<string> symbols = new Stack<string>(input.Reverse());
            
            int result = int.Parse(symbols.Pop());

            while (symbols.Any())
            {
                string nextSymbol = symbols.Pop();

                if (nextSymbol == "+")
                {
                    result += int.Parse(symbols.Pop());
                }
                else if (nextSymbol == "-")
                {
                    result -= int.Parse(symbols.Pop());
                }
            }

            Console.WriteLine(result);
        }
    }
}