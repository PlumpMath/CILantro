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
        [InlineData("empty", "empty")]
        [InlineData("empty", "random_characters")]
        [InlineData("empty", "random_number")]
        [InlineData("hello_world", "empty")]
        [InlineData("hello_world", "hello_world")]
        [InlineData("hello_world", "random_characters")]
        [InlineData("write_0", "empty")]
        [InlineData("write_0", "random_characters")]
        [InlineData("write_0", "random_number")]
        [InlineData("write_1", "empty")]
        [InlineData("write_1", "random_characters")]
        [InlineData("write_1", "random_number")]
        [InlineData("write_2", "empty")]
        [InlineData("write_2", "random_characters")]
        [InlineData("write_2", "random_number")]
        [InlineData("write_3", "empty")]
        [InlineData("write_3", "random_characters")]
        [InlineData("write_3", "random_number")]
        [InlineData("write_4", "empty")]
        [InlineData("write_4", "random_characters")]
        [InlineData("write_4", "random_number")]
        [InlineData("write_5", "empty")]
        [InlineData("write_5", "random_characters")]
        [InlineData("write_5", "random_number")]
        [InlineData("write_6", "empty")]
        [InlineData("write_6", "random_characters")]
        [InlineData("write_6", "random_number")]
        [InlineData("write_7", "empty")]
        [InlineData("write_7", "random_characters")]
        [InlineData("write_7", "random_number")]
        [InlineData("write_8", "empty")]
        [InlineData("write_8", "random_characters")]
        [InlineData("write_8", "random_number")]
        [InlineData("write_m1", "empty")]
        [InlineData("write_m1", "random_characters")]
        [InlineData("write_m1", "random_number")]
        [InlineData("write_m1_alias", "empty")]
        [InlineData("write_m1_alias", "random_characters")]
        [InlineData("write_m1_alias", "random_number")]
        [InlineData("write_some_numbers_int8", "empty")]
        [InlineData("write_some_numbers_int8", "random_characters")]
        [InlineData("write_some_numbers_int8", "random_number")]
        [InlineData("write_some_numbers_int32", "empty")]
        [InlineData("write_some_numbers_int32", "random_characters")]
        [InlineData("write_some_numbers_int32", "random_number")]
        public void ShouldReturnCorrectResults(string programName, string dataName)
        {
            var sourceCodeFileName = programName + SourceCodeFileExtension;
            var sourceCodePath = Path.Combine(SourceCodesDirectoryPath, programName, sourceCodeFileName);
            var sourceCode = File.ReadAllText(sourceCodePath);

            var inputDataDirectoryPath = Path.Combine(SourceCodesDirectoryPath, programName, InputDataDirectoryName);
            var inputDataFileName = dataName + InputDataFileExtension;
            var inputDataPath = Path.Combine(inputDataDirectoryPath, inputDataFileName);

            var outputDataDirectoryPath = Path.Combine(SourceCodesDirectoryPath, programName, OutputDataDirectoryName);
            var outputDataFileName = dataName + OutputDataFileExtension;
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
