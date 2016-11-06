using CILantro.Engine.Lexer.CILTokens;
using System;

namespace CILantro.Engine.Lexer
{
    internal class CILTokenPatternFactory
    {
        private readonly string _assemblyDeclarationTokenPattern = @"\.assembly";

        private readonly string _classDeclarationTokenPattern = @"\.class";

        private readonly string _methodDeclarationTokenPattern = @"\.method";

        private readonly string _leftBraceTokenPattern = @"\{";
        private readonly string _rightBraceTokenPattern = @"\}";
        private readonly string _leftParenthesisTokenPattern = @"\(";
        private readonly string _rightParenthesisTokenPattern = @"\)";

        private readonly string _dotTokenPattern = @"\.";

        private readonly string _identifierTokenPattern = @"[a-zA-Z_]{1}[a-zA-Z0-9]*";

        public string CreatePattern(Type tokenType)
        {
            if (tokenType == typeof(AssemblyDeclarationToken)) return _assemblyDeclarationTokenPattern;

            if (tokenType == typeof(ClassDeclarationToken)) return _classDeclarationTokenPattern;

            if (tokenType == typeof(MethodDeclarationToken)) return _methodDeclarationTokenPattern;

            if (tokenType == typeof(LeftBraceToken)) return _leftBraceTokenPattern;
            if (tokenType == typeof(RightBraceToken)) return _rightBraceTokenPattern;
            if (tokenType == typeof(LeftParenthesisToken)) return _leftParenthesisTokenPattern;
            if (tokenType == typeof(RightParenthesisToken)) return _rightParenthesisTokenPattern;

            if (tokenType == typeof(DotToken)) return _dotTokenPattern;

            if (tokenType == typeof(IdentifierToken)) return _identifierTokenPattern;

            throw new ArgumentException($"Cannot find a pattern for type {tokenType.Name}.");
        }
    }
}
