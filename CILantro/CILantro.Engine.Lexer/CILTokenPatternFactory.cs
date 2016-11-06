using CILantro.Engine.Lexer.CILTokens;
using System;

namespace CILantro.Engine.Lexer
{
    internal class CILTokenPatternFactory
    {
        private readonly string _assemblyDeclarationTokenPattern = @"\.assembly";

        private readonly string _classDeclarationTokenPattern = @"\.class";

        private readonly string _leftBracePattern = @"\{";
        private readonly string _rightBracePattern = @"\}";

        private readonly string _identifierTokenPattern = @"[a-zA-Z_]{1}[a-zA-Z0-9]*";

        public string CreatePattern(Type tokenType)
        {
            if (tokenType == typeof(AssemblyDeclarationToken)) return _assemblyDeclarationTokenPattern;

            if (tokenType == typeof(ClassDeclarationToken)) return _classDeclarationTokenPattern;

            if (tokenType == typeof(LeftBraceToken)) return _leftBracePattern;
            if (tokenType == typeof(RightBraceToken)) return _rightBracePattern;

            if (tokenType == typeof(IdentifierToken)) return _identifierTokenPattern;

            throw new ArgumentException($"Cannot find a pattern for type {tokenType.Name}.");
        }
    }
}
