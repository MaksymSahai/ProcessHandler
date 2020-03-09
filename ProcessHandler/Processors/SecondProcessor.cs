using ProcessHandler.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessHandler.Processors
{
    public class SecondProcessor : IProcess
    {
        public bool Process()
        {
            Console.WriteLine("Second process return");
            return true;
        }
    }
}
