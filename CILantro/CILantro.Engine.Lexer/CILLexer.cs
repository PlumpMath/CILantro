using CILantro.Engine.Lexer.CILTokens;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CILantro.Engine.Lexer
{
    public class CILLexer
    {
        private readonly CILTokenExtractor _cilTokenExtractor = new CILTokenExtractor();

        public List<CILToken> Tokenize(string sourceCode)
        {
            var result = new List<CILToken>();

            var plainSourceCode = Regex.Replace(sourceCode, @"\s+", " ").Trim();

            var tokenExtract = _cilTokenExtractor.ExtractToken(plainSourceCode);
            while(tokenExtract != null)
            {
                result.Add(tokenExtract.Token);
                plainSourceCode = tokenExtract.Rest.Trim();

                tokenExtract = _cilTokenExtractor.ExtractToken(plainSourceCode);
            }

            if (!string.IsNullOrEmpty(plainSourceCode)) throw new ArgumentException("Cannot tokenize source code.");

            return result;
        }
    }
}
