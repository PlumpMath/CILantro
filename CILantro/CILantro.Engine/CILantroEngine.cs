using CILantro.Engine.Lexer;

namespace CILantro.Engine
{
    public class CILantroEngine
    {
        private readonly CILLexer _cilLexer = new CILLexer();

        public void Process(string sourceCode)
        {
            var cilTokens = _cilLexer.Tokenize(sourceCode);
        }
    }
}
