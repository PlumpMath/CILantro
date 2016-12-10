using CILantro.Engine.Interpreter;
using System.IO;

namespace CILantro.Engine.Interpreter.Tests
{
    public class CILInterpreterTests
    {
        private readonly CILInterpreter _interpreter = new CILInterpreter();

        private readonly string SourceCodeFileExtension = ".il";

        private readonly string SourceCodesDirectoryPath = @"D:\UWr\mgr\semestr IV\CILantro\CILSourceCodes";

        public void ShouldCorrectlyInterpretSourceCodes(string programName)
        {
            var sourceCodeFileName = programName + SourceCodeFileExtension;
            var sourceCodePath = Path.Combine(SourceCodesDirectoryPath, programName, sourceCodeFileName);
            var sourceCode = File.ReadAllText(sourceCodePath);

            _interpreter.StartInterpreter()
        }
    }
}
