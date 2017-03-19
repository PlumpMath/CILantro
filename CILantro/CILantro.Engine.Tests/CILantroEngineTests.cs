using System.IO;
using System.Linq;
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
        [InlineData("empty")]
        [InlineData("hello_world")]
        [InlineData("write_0")]
        [InlineData("write_1")]
        [InlineData("write_2")]
        [InlineData("write_3")]
        [InlineData("write_4")]
        [InlineData("write_5")]
        [InlineData("write_6")]
        [InlineData("write_7")]
        [InlineData("write_8")]
        [InlineData("write_m1")]
        [InlineData("write_m1_alias")]
        [InlineData("write_some_numbers_int8")]
        [InlineData("write_some_numbers_int32")]
        [InlineData("add_some_numbers")]
        [InlineData("add_two_numbers")]
        [InlineData("duplicate")]
        [InlineData("unconditional_branch")]
        [InlineData("branch_if_true")]
        public void ShouldReturnCorrectResults(string programName)
        {
            var sourceCodeFileName = programName + SourceCodeFileExtension;
            var sourceCodePath = Path.Combine(SourceCodesDirectoryPath, programName, sourceCodeFileName);
            var sourceCode = File.ReadAllText(sourceCodePath);

            var inputDataDirectoryPath = Path.Combine(SourceCodesDirectoryPath, programName, InputDataDirectoryName);
            var inputDataDirectoryInfo = new DirectoryInfo(inputDataDirectoryPath);
            var inputDataFiles = inputDataDirectoryInfo.GetFiles().Where(f => f.Extension.Equals(InputDataFileExtension));

            var outputDataDirectoryPath = Path.Combine(SourceCodesDirectoryPath, programName, OutputDataDirectoryName);

            foreach (var inputDataFile in inputDataFiles)
            {
                var inputDataPath = inputDataFile.FullName;

                var outputDataPath = Path.ChangeExtension(Path.Combine(outputDataDirectoryPath, inputDataFile.Name), OutputDataFileExtension);
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
}
