using CILantro.Engine.Parser;

namespace CILantro.Engine
{
    public class CILantroEngine
    {
        private readonly CILParser _cilParser = new CILParser();

        public void Process(string sourceCode)
        {
            var cilProgram = _cilParser.Parse(sourceCode);
        }
    }
}
