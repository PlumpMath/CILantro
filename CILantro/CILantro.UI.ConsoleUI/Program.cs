using CILantro.Engine;
using CILantro.Helpers;
using System;
using System.IO;

namespace CILantro.UI.ConsoleUI
{
    public class Program
    {
        private static readonly CILantroEngine _cilantroEngine = new CILantroEngine();

        private static void Main(string[] args)
        {
            Console.WriteLine(Messages.WelcomeMessage);

            var config = CollectConfiguration(args);
            if(!config.Validate())
            {
                Console.WriteLine();
                Console.WriteLine(Messages.BadUsageMessage);
                Console.WriteLine();
                Console.WriteLine(Messages.UsageInfoMessage);
                return;
            }

            var sourceCode = File.ReadAllText(config.SourceCodeFilePath);
            _cilantroEngine.Process(sourceCode);

            Console.ReadKey();
        }

        private static ConsoleUIConfiguration CollectConfiguration(string[] args)
        {
            var sourceCodeFilePath = (string)args.GetValueOrNull(0);

            return new ConsoleUIConfiguration
            {
                SourceCodeFilePath = sourceCodeFilePath
            };
        }
    }
}