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

            try
            {
                var sourceCode = File.ReadAllText(config.SourceCodeFilePath);

                var consoleReader = new StreamReader(Console.OpenStandardInput());
                var consoleWriter = new StreamWriter(Console.OpenStandardOutput());

                Console.WriteLine();
                _cilantroEngine.Process(sourceCode, consoleReader, consoleWriter);
                Console.WriteLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(Messages.ErrorMessage);
                Console.WriteLine(ex.Message);
            }
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