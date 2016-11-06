namespace CILantro.Engine.Lexer.CILTokens
{
    public class IdentifierToken : CILToken
    {
        public string Identifier { get; private set; }

        public IdentifierToken(string identifier)
        {
            Identifier = identifier;
        }
    }
}
