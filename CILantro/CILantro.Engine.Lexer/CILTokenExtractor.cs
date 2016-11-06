﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CILantro.Engine.Lexer
{
    internal class CILTokenExtractor
    {
        private CILTokenRegister _cilTokenRegister = new CILTokenRegister();
        private CILTokenPatternFactory _cilTokenRegexFactory = new CILTokenPatternFactory();
        private CILTokenFactory _cilTokenFactory = new CILTokenFactory();

        private List<Type> _tokenTypes;

        public CILTokenExtractor()
        {
            _tokenTypes = _cilTokenRegister.GetTokenTypes();
        }

        public CILTokenExtract ExtractToken(string sourceCode)
        {
            foreach(var tokenType in _tokenTypes)
            {
                var tokenPattern = $"^{_cilTokenRegexFactory.CreateRegex(tokenType)}";
                var tokenRegex = new Regex(tokenPattern);
                var tokenMatch = tokenRegex.Match(sourceCode);
                if(tokenMatch.Success)
                {
                    return new CILTokenExtract
                    {
                        Token = _cilTokenFactory.CreateToken(tokenType),
                        Rest = sourceCode.Substring(tokenMatch.Length)
                    };
                }
            }

            return null;
        }
    }
}
