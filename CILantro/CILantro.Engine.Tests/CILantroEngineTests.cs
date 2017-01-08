using System;
using System.IO;
using Xunit;

namespace CILantro.Engine.Tests
{
    public class CILantroEngineTests
    {
        private CILantroEngine _engine = new CILantroEngine();

        private readonly string SourceCodeFileExtension = ".il";

        private readonly string InputDataFileExtension = ".in";

        private readonly string OutputDataFileExtension = ".out";

        private readonly string SourceCodesDirectoryPath = @"D:\UWr\mgr\semestr IV\CILantro\CILSourceCodes";

        private readonly string InputDataDirectoryName = "in";

        private readonly string OutputDataDirectoryName = "out";

        [Theory]
        [InlineData("empty", "empty", "empty")]
        [InlineData("empty", "random_characters", "random_characters")]
        [InlineData("empty", "random_number", "random_number")]
        [InlineData("hello_world", "empty", "empty")]
        [InlineData("hello_world", "hello_world", "hello_world")]
        [InlineData("hello_world", "random_characters", "random_characters")]
        public void ShouldReturnCorrectResults(string programName, string inputDataName, string outputDataName)
        {
            var sourceCodeFileName = programName + SourceCodeFileExtension;
            var sourceCodePath = Path.Combine(SourceCodesDirectoryPath, programName, sourceCodeFileName);
            var sourceCode = File.ReadAllText(sourceCodePath);

            var inputDataDirectoryPath = Path.Combine(SourceCodesDirectoryPath, programName, InputDataDirectoryName);
            var inputDataFileName = inputDataName + InputDataFileExtension;
            var inputDataPath = Path.Combine(inputDataDirectoryPath, inputDataFileName);

            var outputDataDirectoryPath = Path.Combine(SourceCodesDirectoryPath, programName, OutputDataDirectoryName);
            var outputDataFileName = outputDataName + OutputDataFileExtension;
            var outputDataPath = Path.Combine(outputDataDirectoryPath, outputDataFileName);
            var expectedOutputData = File.ReadAllText(outputDataPath);

            using (var inputDataStream = new StreamReader(inputDataPath))
            {
                using (var outputMemoryStream = new MemoryStream())
                {
                    _engine.Process(sourceCode, inputDataStream, new StreamWriter(outputMemoryStream));

                    outputMemoryStream.Position = 0;
                    var outputDataReader = new StreamReader(outputMemoryStream);
                    var outputData = outputDataReader.ReadToEnd();

                    Assert.Equal(expectedOutputData, outputData);
                }
            }
        }
    }
}
