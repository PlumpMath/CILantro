using System;
using System.IO;
using System.Reflection;
using Xunit;

namespace CILantro.Engine.Tests
{
    public class CILantroEngineTests
    {
        private CILantroEngine _engine = new CILantroEngine();

        private readonly string SourceCodeFileExtension = ".il";

        private readonly string InputDataFileExtension = ".in";

        private readonly string OutputDataFileExtension = ".out";

        private readonly string SourceCodesDirectoryName = "CILSourceCodes";

        private readonly string InputDataDirectoryName = "CILInputData";

        private readonly string OutputDataDirectoryName = "CILOutputData";

        private string WorkingDirPath
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uriBuilder = new UriBuilder(codeBase);
                var assemblyPath = Uri.UnescapeDataString(uriBuilder.Path);
                var assemblyDirPath = Path.GetDirectoryName(assemblyPath);
                return assemblyDirPath;
            }
        }

        private string SourceCodesDirectoryPath
        {
            get { return Path.Combine(WorkingDirPath, SourceCodesDirectoryName); }
        }

        private string InputDataDirectoryPath
        {
            get { return Path.Combine(WorkingDirPath, InputDataDirectoryName); }
        }

        private string OutputDataDirectoryPath
        {
            get { return Path.Combine(WorkingDirPath, OutputDataDirectoryName); }
        }

        [Theory]
        [InlineData("0001_empty", "0001", "0001")]
        public void ShouldCorrectlyInterpretSourceCodes(string programName, string inputDataName, string outputDataName)
        {
            Console.WriteLine(programName);

            var sourceCodeFileName = programName + SourceCodeFileExtension;
            var sourceCodePath = Path.Combine(SourceCodesDirectoryPath, sourceCodeFileName);
            var sourceCode = File.ReadAllText(sourceCodePath);

            var inputDataFileName = inputDataName + InputDataFileExtension;
            var inputDataPath = Path.Combine(InputDataDirectoryPath, programName, inputDataFileName);

            using (var inputDataStream = new StreamReader(inputDataPath))
            {
                _engine.Process(sourceCode, inputDataStream, new StreamWriter(Console.OpenStandardOutput()));
            }
        }
    }
}
