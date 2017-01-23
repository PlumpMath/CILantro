using CILantro.Engine.Interpreter;
using CILantro.Engine.Parser;
using System.IO;

namespace CILantro.Engine
{
    public class CILantroEngine
    {
        private readonly CILParser _parser = new CILParser();

        private readonly CILInterpreter _interpreter = new CILInterpreter();

        public void Process(string sourceCode, StreamReader reader, StreamWriter writer)
        {
            var cilProgram = _parser.Parse(sourceCode);
            _interpreter.StartInterpreter(cilProgram, reader, writer);
        }
    }
}
