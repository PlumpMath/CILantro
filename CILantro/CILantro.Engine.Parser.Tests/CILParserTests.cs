using System.IO;
using Xunit;

namespace CILantro.Engine.Parser.Tests
{
    public class CILParserTests
    {
        private CILParser _parser = new CILParser();

        private readonly string SourceCodeFileExtension = ".il";

        private readonly string SourceCodesDirectoryPath = @"D:\UWr\mgr\semestr IV\CILantro\CILSourceCodes";

        [Theory]
        [InlineData("empty")]
        [InlineData("read_key")]
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
        public void ShouldParseProgramWithoutErrors(string programName)
        {
            var sourceCodeFileName = programName + SourceCodeFileExtension;
            var sourceCodePath = Path.Combine(SourceCodesDirectoryPath, programName, sourceCodeFileName);
            var sourceCode = File.ReadAllText(sourceCodePath);

            _parser.Parse(sourceCode);
        }
    }
}
