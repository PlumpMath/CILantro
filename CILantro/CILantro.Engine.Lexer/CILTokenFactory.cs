using CILantro.Engine.Lexer.CILTokens;
using System;

namespace CILantro.Engine.Lexer
{
    internal class CILTokenFactory
    {
        public CILToken CreateToken(Type type)
        {
            if (type == typeof(AssemblyDeclarationToken)) return new AssemblyDeclarationToken();
            return null;
        }
    }
}
