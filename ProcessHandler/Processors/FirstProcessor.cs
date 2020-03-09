using ProcessHandler.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessHandler.Processors
{
    public class FirstProcessor : IProcess
    {
        public bool Process()
        {
            Console.WriteLine("First process return");
            return true;
        }
    }
}
