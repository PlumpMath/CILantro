using CILantro.Engine.Lexer.CILTokens;
using System;
using System.Collections.Generic;

namespace CILantro.Engine.Lexer
{
    internal class CILTokenRegister
    {
        private List<Type> _tokenTypes = new List<Type>();

        public CILTokenRegister()
        {
            RegisterToken(typeof(AssemblyDeclarationToken));

            RegisterToken(typeof(IdentifierToken));
        }

        public List<Type> GetTokenTypes()
        {
            return _tokenTypes;
        }

        private void RegisterToken(Type tokenType)
        {
            _tokenTypes.Add(tokenType);
        }
    }
}
