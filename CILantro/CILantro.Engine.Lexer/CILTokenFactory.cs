using CILantro.Engine.Lexer.CILTokens;
using System;

namespace CILantro.Engine.Lexer
{
    internal class CILTokenFactory
    {
        public CILToken CreateToken(Type type, string tokenString)
        {
            if (type == typeof(AssemblyDeclarationToken)) return new AssemblyDeclarationToken();

            if (type == typeof(IdentifierToken)) return new IdentifierToken(tokenString);

            throw new ArgumentException($"Cannot create a token for type {type.Name}.");
        }
    }
}
