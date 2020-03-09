using ProcessHandler.Abstraction;
using ProcessHandler.Processors;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessHandler
{
    public class ProcessFactory
    {
        IDictionary<ProcessorEnum, Type> dictionary = new Dictionary<ProcessorEnum, Type>()
        {
            {ProcessorEnum.First, typeof(FirstProcessor)},
            {ProcessorEnum.Second, typeof(SecondProcessor)},
            {ProcessorEnum.Third, typeof(ThirdProcessor)}
        };

        public IProcess GetProcess(ProcessorEnum processorType)
        {
            dictionary.TryGetValue(processorType, out var type);
            return (IProcess)Activator.CreateInstance(type);
        }
    }
}
