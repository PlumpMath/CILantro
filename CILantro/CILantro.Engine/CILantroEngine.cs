using CILantro.Engine.Interpreter;
using CILantro.Engine.Parser;

namespace CILantro.Engine
{
    public class CILantroEngine
    {
        private readonly CILParser _cilParser = new CILParser();

        private readonly CILInterpreter _cilInterpreter = new CILInterpreter();

        public void Process(string sourceCode)
        {
            var cilProgram = _cilParser.Parse(sourceCode);
            _cilInterpreter.Interpret(cilProgram);
        }
    }
}
