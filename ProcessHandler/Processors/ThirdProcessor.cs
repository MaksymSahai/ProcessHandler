using ProcessHandler.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessHandler.Processors
{
    public class ThirdProcessor : IProcess
    {
        public bool Process()
        {
            Console.WriteLine("Third process return");
            return true;
        }
    }
}
