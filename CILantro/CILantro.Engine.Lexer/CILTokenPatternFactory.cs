using CILantro.Engine.Lexer.CILTokens;
using System;

namespace CILantro.Engine.Lexer
{
    internal class CILTokenPatternFactory
    {
        private readonly string _assemblyDeclarationTokenRegex = @"\.assembly";

        public string CreateRegex(Type tokenType)
        {
            if (tokenType == typeof(AssemblyDeclarationToken)) return _assemblyDeclarationTokenRegex;
            return null;
        }
    }
}
