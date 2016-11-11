using CILantro.Engine.Interpreter;
using CILantro.Engine.Parser;
using System.IO;

namespace CILantro.Engine
{
    public class CILantroEngine
    {
        private readonly CILParser _cilParser = new CILParser();

        private readonly CILInterpreter _cilInterpreter = new CILInterpreter();

        public void Process(string sourceCode, StreamReader reader, StreamWriter writer)
        {
            var cilProgram = _cilParser.Parse(sourceCode);
            _cilInterpreter.StartInterpreter(cilProgram, reader, writer);
        }
    }
}
