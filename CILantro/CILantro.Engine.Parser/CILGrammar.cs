using Irony.Parsing;

namespace CILantro.Engine.Parser
{
    internal class CILGrammar : Grammar
    {
        public CILGrammar()
        {
            // declaration keywords

            var assemblyDeclKeyword = ToTerm(".assembly");
            var classDeclKeyword = ToTerm(".class");
            var entryPointKeyword = ToTerm(".entrypoint");
            var methodDeclKeyword = ToTerm(".method");

            // keywords

            var cilKeyword = ToTerm("cil");
            var managedKeyword = ToTerm("managed");
            var returnKeyword = ToTerm("ret");
            var staticKeyword = ToTerm("static");
            var voidKeyword = ToTerm("void");

            // punctuation

            var dot = ToTerm(".");
            var leftBrace = ToTerm("{");
            var rightBrace = ToTerm("}");
            var leftParenthesis = ToTerm("(");
            var rightParenthesis = ToTerm(")");

            // identifiers

            var identifier = new IdentifierTerminal("identifier");

            var namespaceIdentifier = new NonTerminal("namespaceIdentifier");
            namespaceIdentifier.Rule = identifier | (identifier + dot + namespaceIdentifier);

            // methods

            var methodParameters = new NonTerminal("methodParameters");
            methodParameters.Rule = leftParenthesis + rightParenthesis;

            var methodDeclBlock = new NonTerminal("methodDeclarationBlock");
            methodDeclBlock.Rule = leftBrace + entryPointKeyword + returnKeyword + rightBrace;

            var methodDeclaration = new NonTerminal("methodDeclaration");
            methodDeclaration.Rule = methodDeclKeyword + (staticKeyword | Empty) + voidKeyword + identifier + methodParameters + cilKeyword + managedKeyword + methodDeclBlock;

            // classes

            var classDeclBlock = new NonTerminal("classDeclarationBlock");
            classDeclBlock.Rule = leftBrace + methodDeclaration + rightBrace;

            var classDeclaration = new NonTerminal("classDeclaration");
            classDeclaration.Rule = classDeclKeyword + namespaceIdentifier + classDeclBlock;

            // assemblies

            var assemblyDeclBlock = new NonTerminal("assemblyDeclarationBlock");
            assemblyDeclBlock.Rule = leftBrace + rightBrace;

            var assemblyDeclaration = new NonTerminal("assemblyDeclaration");
            assemblyDeclaration.Rule = assemblyDeclKeyword + identifier + assemblyDeclBlock;

            // program

            var program = new NonTerminal("program");
            program.Rule = assemblyDeclaration + classDeclaration;

            // root

            Root = program;
        }
    }
}
