namespace _02._Sets_of_Elements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToArray();

            var n = input[0];
            var m = input[1];

            var setN = new HashSet<int>();
            var setM = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                setN.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                setM.Add(number);
            }

            setN.IntersectWith(setM);

            Console.WriteLine(string.Join(" ", setN));
        }
    }
}