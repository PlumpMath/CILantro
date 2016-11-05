using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CILantro.Engine.Lexer
{
    public class CILLexer
    {
        public List<CILToken> Tokenize(string sourceCode)
        {
            var codeWithoutWhiteSpaces = Regex.Replace(sourceCode, @"\s+", " ");

            return new List<CILToken>();
        }
    }
}
