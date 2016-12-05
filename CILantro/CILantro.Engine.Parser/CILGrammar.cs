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

            var callKeyword = ToTerm("call", "callKeyword");
            var cilKeyword = ToTerm("cil", "cilKeyword");
            var externKeyword = ToTerm("extern", "externKeyword");
            var managedKeyword = ToTerm("managed", "managedKeyword");
            var popKeyword = ToTerm("pop", "popKeyword");
            var retKeyword = ToTerm("ret", "retKeyword");
            var staticKeyword = ToTerm("static", "staticKeyword");
            var valuetypeKeyword = ToTerm("valuetype", "valuetypeKeyword");
            var voidKeyword = ToTerm("void", "voidKeyword");

            // optional keywords
            var optionalExternKeyword = new NonTerminal("optionalExternKeyword");
            optionalExternKeyword.Rule = externKeyword | Empty;

            // punctuation

            var dot = ToTerm(".");
            var colon = ToTerm(":");
            var leftBrace = ToTerm("{");
            var rightBrace = ToTerm("}");
            var leftParenthesis = ToTerm("(");
            var rightParenthesis = ToTerm(")");
            var leftBracket = ToTerm("[");
            var rightBracket = ToTerm("]");

            // identifiers

            var identifier = new IdentifierTerminal("identifier");

            var namespaceIdentifier = new NonTerminal("namespaceIdentifier");
            namespaceIdentifier.Rule = identifier | (identifier + dot + namespaceIdentifier);

            var typeIdentifier = new NonTerminal("typeIdentifier");
            typeIdentifier.Rule = identifier | (identifier + dot + typeIdentifier);

            var methodIdentifier = new NonTerminal("methodIdentifier");
            methodIdentifier.Rule = typeIdentifier + colon + colon + identifier + leftParenthesis + rightParenthesis;

            // definitions

            var returnTypeDefinition = new NonTerminal("returnTypeDefinition");
            returnTypeDefinition.Rule = leftBracket + namespaceIdentifier + rightBracket + typeIdentifier;

            var methodDefinition = new NonTerminal("methodDefinition");
            methodDefinition.Rule = leftBracket + namespaceIdentifier + rightBracket + methodIdentifier;

            // instructions

            var callInstruction = new NonTerminal("callInstruction");
            callInstruction.Rule = callKeyword + valuetypeKeyword + returnTypeDefinition + methodDefinition;

            var popInstruction = new NonTerminal("popInstruction");
            popInstruction.Rule = popKeyword;

            var retInstruction = new NonTerminal("retInstruction");
            retInstruction.Rule = retKeyword;

            var instruction = new NonTerminal("instruction");
            instruction.Rule = callInstruction | popInstruction | retInstruction;

            var instructionsSequence = new NonTerminal("instructionsSequence");
            instructionsSequence.Rule = instruction | (instruction + instructionsSequence);

            // methods

            var methodParameters = new NonTerminal("methodParameters");
            methodParameters.Rule = leftParenthesis + rightParenthesis;

            var methodDeclBlock = new NonTerminal("methodDeclarationBlock");
            methodDeclBlock.Rule = leftBrace + entryPointKeyword + instructionsSequence + rightBrace;

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
            assemblyDeclaration.Rule = assemblyDeclKeyword + optionalExternKeyword + identifier + assemblyDeclBlock;

            var assemblyDeclarations = new NonTerminal("assemblyDeclarations");
            assemblyDeclarations.Rule = assemblyDeclaration | (assemblyDeclaration + assemblyDeclarations);

            // program

            var program = new NonTerminal("program");
            program.Rule = assemblyDeclarations + classDeclaration;

            // root

            Root = program;
        }
    }
}
