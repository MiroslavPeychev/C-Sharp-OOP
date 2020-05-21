namespace MortalEngines.IO.Contracts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Input;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}