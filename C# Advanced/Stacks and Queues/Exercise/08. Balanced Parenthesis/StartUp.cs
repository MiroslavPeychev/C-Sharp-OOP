namespace _08._Balanced_Parenthesis
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            Stack<char> stackOfParenhesis = new Stack<char>();
            string parenthesis = Console.ReadLine();
            char[] openParenthesis = new char[] { '(', '[', '{' };
            bool isValid = true;

            for (int i = 0; i < parenthesis.Length; i++)
            {
                char currentBracket = parenthesis[i];

                if (openParenthesis.Contains(currentBracket))
                {
                    stackOfParenhesis.Push(currentBracket);
                    continue;
                }

                if (stackOfParenhesis.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParenhesis.Peek() == '(' && currentBracket == ')')
                {
                    stackOfParenhesis.Pop();
                }
                else if (stackOfParenhesis.Peek() == '[' && currentBracket == ']')
                {
                    stackOfParenhesis.Pop();
                }
                else if (stackOfParenhesis.Peek() == '{' && currentBracket == '}')
                {
                    stackOfParenhesis.Pop();
                }
            }

            if (isValid && stackOfParenhesis.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}