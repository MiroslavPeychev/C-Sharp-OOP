namespace _7._Hot_Potato
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            string[] allChildren = Console.ReadLine()
                .Split(' ');
            int number = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>(allChildren);
            int counter = 1;

            while (children.Count > 1)
            {
                var currentCild = children.Dequeue();

                if (counter % number != 0)
                {
                    children.Enqueue(currentCild);
                }
                else
                {
                    Console.WriteLine($"Removed {currentCild}");
                }

                counter++;
            }

            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}