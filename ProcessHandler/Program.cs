using System;

namespace ProcessHandler
{
    class Program
    {
        public static readonly string ExitString = "exit";
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    var input = Console.ReadLine();
                    if (input.ToLower().Equals(ExitString))
                        break;

                    var inputInt = int.Parse(input);

                    if (Enum.IsDefined(typeof(ProcessorEnum), inputInt))
                    {
                        var processor = (ProcessorEnum)inputInt;
                        var factory = new ProcessFactory();
                        var processHandler = factory.GetProcess(processor);
                        processHandler.Process();
                    }
                    else
                    {
                        Console.WriteLine($"{input} is not defined in enum");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Environment.Exit(0);
        }
    }
}
