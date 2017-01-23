using Irony.Parsing;

namespace CILantro.Engine.Parser
{
    internal class CILGrammar : Grammar
    {
        public CILGrammar()
        {
            var declarations = new NonTerminal(CILGrammarTokenNames.Declarations);
            declarations.Rule = "fewfw";

            Root = declarations;
        }
    }
}
