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
        [InlineData("SP_empty")]
        [InlineData("SP_hello_world")]
        [InlineData("SP_write_0")]
        [InlineData("SP_write_1")]
        [InlineData("SP_write_2")]
        [InlineData("SP_write_3")]
        [InlineData("SP_write_4")]
        [InlineData("SP_write_5")]
        [InlineData("SP_write_6")]
        [InlineData("SP_write_7")]
        [InlineData("SP_write_8")]
        [InlineData("SP_write_m1")]
        [InlineData("SP_write_m1_alias")]
        [InlineData("SP_write_some_numbers_int8")]
        [InlineData("SP_write_some_numbers_int32")]
        [InlineData("SP_add_some_numbers")]
        [InlineData("SP_add_two_numbers")]
        [InlineData("SP_duplicate")]
        [InlineData("SP_unconditional_branch")]
        [InlineData("SP_branch_if_true")]
        [InlineData("SP_branch_if_false")]
        [InlineData("SP_unconditional_branch_short")]
        [InlineData("SP_branch_if_true_short")]
        [InlineData("SP_branch_if_false_short")]
        [InlineData("SP_branch_if_equal")]
        [InlineData("SP_branch_if_greater_or_equal")]
        [InlineData("SP_branch_if_greater")]
        [InlineData("SP_branch_if_less_or_equal")]
        [InlineData("SP_branch_if_less")]
        [InlineData("SP_branch_if_not_equal")]
        [InlineData("SP_leave")]
        [InlineData("SP_add_overflow")]
        [InlineData("SP_and")]
        [InlineData("SP_div")]
        [InlineData("SP_sub")]
        [InlineData("SP_mul")]
        [InlineData("SP_or")]
        [InlineData("SP_shifts")]
        [InlineData("SP_ns")]
        [InlineData("SP_cgt")]
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
