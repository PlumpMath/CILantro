using Irony.Parsing;

namespace CILantro.Engine.Parser
{
    internal class CILGrammar : Grammar
    {
        public CILGrammar()
        {
            // punctuation

            var leftBrace = ToTerm("{", GrammarNames.LeftBrace);
            var rightBrace = ToTerm("}", GrammarNames.RightBrace);

            // tokens

            var dotAssemblyToken = ToTerm(".assembly", GrammarNames.DotAssemblyToken);
            var externToken = ToTerm("extern", GrammarNames.ExternToken);

            // lexical tokens

            var id = new IdentifierTerminal(GrammarNames.Id);

            // productions

            var name = new NonTerminal(GrammarNames.Name);
            name.Rule = id;

            var assemblyRefHead = new NonTerminal(GrammarNames.AssemblyRefHead);
            assemblyRefHead.Rule = dotAssemblyToken + externToken + name;

            var assemblyRefDeclarations = new NonTerminal(GrammarNames.AssemblyRefDeclarations);
            assemblyRefDeclarations.Rule = Empty;

            var declaration = new NonTerminal(GrammarNames.Declaration);
            declaration.Rule = assemblyRefHead + leftBrace + assemblyRefDeclarations + rightBrace;

            var declarations = new NonTerminal(GrammarNames.Declarations);
            declarations.Rule =
                Empty |
                declarations + declaration;

            Root = declarations;
        }
    }
}
