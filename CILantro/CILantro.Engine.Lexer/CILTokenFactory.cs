using CILantro.Engine.Lexer.CILTokens;
using System;

namespace CILantro.Engine.Lexer
{
    internal class CILTokenFactory
    {
        public CILToken CreateToken(Type type, string tokenString)
        {
            if (type == typeof(AssemblyDeclarationToken)) return new AssemblyDeclarationToken();
            if (type == typeof(ClassDeclarationToken)) return new ClassDeclarationToken();
            if (type == typeof(MethodDeclarationToken)) return new MethodDeclarationToken();
            if (type == typeof(EntryPointDeclarationToken)) return new EntryPointDeclarationToken();

            if (type == typeof(CILKeywordToken)) return new CILKeywordToken();
            if (type == typeof(StaticKeywordToken)) return new StaticKeywordToken();
            if (type == typeof(VoidKeywordToken)) return new VoidKeywordToken();

            if (type == typeof(LeftBraceToken)) return new LeftBraceToken();
            if (type == typeof(RightBraceToken)) return new RightBraceToken();
            if (type == typeof(LeftParenthesisToken)) return new LeftParenthesisToken();
            if (type == typeof(RightParenthesisToken)) return new RightParenthesisToken();

            if (type == typeof(DotToken)) return new DotToken();

            if (type == typeof(IdentifierToken)) return new IdentifierToken(tokenString);

            throw new ArgumentException($"Cannot create a token for type {type.Name}.");
        }
    }
}
